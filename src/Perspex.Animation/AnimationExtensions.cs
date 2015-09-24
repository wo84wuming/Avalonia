﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;

namespace Perspex.Animation
{
    /// <summary>
    /// Defines animation extension methods.
    /// </summary>
    public static class AnimationExtensions
    {
        /// <summary>
        /// Returns a new <see cref="PropertyTransition"/> for the specified
        /// <see cref="PerspexProperty"/> using linear easing.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="PerspexProperty"/>.</typeparam>
        /// <param name="property">The property to animate.</param>
        /// <param name="milliseconds">The animation duration in milliseconds.</param>
        /// <returns>
        /// A <see cref="PropertyTransition"/> that can be added to the
        /// <see cref="Animatable.PropertyTransitions"/> collection.
        /// </returns>
        public static PropertyTransition Transition<T>(this PerspexProperty<T> property, int milliseconds)
        {
            return Transition(property, TimeSpan.FromMilliseconds(milliseconds));
        }

        /// <summary>
        /// Returns a new <see cref="PropertyTransition"/> for the specified
        /// <see cref="PerspexProperty"/> using linear easing.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="PerspexProperty"/>.</typeparam>
        /// <param name="property">The property to animate.</param>
        /// <param name="duration">The animation duration.</param>
        /// <returns>
        /// A <see cref="PropertyTransition"/> that can be added to the
        /// <see cref="Animatable.PropertyTransitions"/> collection.
        /// </returns>
        public static PropertyTransition Transition<T>(this PerspexProperty<T> property, TimeSpan duration)
        {
            return new PropertyTransition(property, duration, LinearEasing.For<T>());
        }
    }
}
