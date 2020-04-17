﻿using System;
using System.Linq;
using NSubstitute.Core;
using NSubstitute.Instantiation;

namespace NSubstitute
{
    /// <summary>
    /// Provides functionality to instantiate a type with dependencies automatically substituted.
    /// For example: <c>Instance.Of&lt;SomeClass&gt;()</c>
    /// </summary>
    public static class Instance
    {
        private static readonly INameForSubstitute NameForSubstitute = new NameForSubstitute();

        /// <summary>
        /// Creates an instance of a type with dependencies automatically substituted.
        /// </summary>
        /// <typeparam name="TType">The type of a class to instantiate.</typeparam>
        /// <param name="dependencies">Optional dependencies used to instantiate the type. These will not be substituted.</param>
        /// <returns>An instance of the type.</returns>
        /// <remarks>Interfaces and abstract classes are not supported.</remarks>
        public static TType Of<TType>(params object[] dependencies)
            where TType : class
        {
            Type type = typeof(TType);
            if (type.IsInterface)
                throw new MemberAccessException(SR.Format(SR.CannotCreateInstanceOfInterface, type.FullName));
            if (type.IsAbstract)
                throw new MemberAccessException(SR.Format(SR.CannotCreateInstanceOfAbstractClass, type.FullName));

            dependencies = dependencies ?? Array.Empty<object>();

            Activation activation = ActivationLookup
                .For<TType>(dependencies)
                .OrderBy(a => a.ConstructorInfo.IsPublic)
                .ThenBy(a => a.Match == ArgumentMatch.Exact)
                .ThenBy(a => a.ConstructorInfo.GetParameters().Length)
                .ThenBy(a => a.Match)
                .FirstOrDefault();

            return activation != null
                ? activation.Invoke<TType>()
                : throw new MissingMethodException(SR.Format(SR.CannotFindMatchingConstructor, type.FullName, NameForSubstitute.GetNamesFor(dependencies)));
        }
    }
}