﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMappingRule.cs"company="RHEA System S.A.">
//    Copyright(c) 2020 RHEA System S.A.
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Kamil Wojnowski, Nathanael Smiechowski.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DEHPCommon.MappingRules.Core
{
    /// <summary>
    /// Defines a mapping rule for <see cref="MappingRule{T,T}"/>
    /// </summary>
    public interface IMappingRule
    {
        /// <summary>
        /// Transforms a object of type <see cref="TInput"/> to another one of type <see cref="TOutput"/>
        /// </summary>
        void Transform();
    }
}
