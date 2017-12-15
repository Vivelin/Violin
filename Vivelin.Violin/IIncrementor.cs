using System;

namespace Vivelin.Violin
{
    /// <summary>
    /// Defines a method that determines the successor to a value.
    /// </summary>
    /// <typeparam name="T">The type of value to increment.</typeparam>
    public interface IIncrementor<T>
    {
        /// <summary>
        /// Increments a value.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <returns>The successor to <paramref name="value"/>.</returns>
        T Increment(T value);
    }
}