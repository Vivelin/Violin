using System;
using System.Text;

namespace Vivelin.Violin
{
    /// <summary>
    /// Provides a set of static methods that add additional functionality to
    /// string objects.
    /// </summary>
    public static class StringExtensions
    {
        private static readonly IIncrementor<string> defaultIncrementor = new AlphanumericStringIncrementor();

        /// <summary>
        /// Returns a string that succeeds the current string.
        /// </summary>
        /// <param name="value">The string to increment.</param>
        /// <returns>The successor to <paramref name="value"/>.</returns>
        public static string Increment(this string value) => value.Increment(defaultIncrementor);

        /// <summary>
        /// Returns a string that succeeds the current string.
        /// </summary>
        /// <param name="value">The string to increment.</param>
        /// <param name="incrementor">
        /// An <see cref="IIncrementor{T}"/> object that determines the successor
        /// to string values.
        /// </param>
        /// <returns>
        /// The successor to <paramref name="value"/> as determined by <paramref name="incrementor"/>.
        /// </returns>
        public static string Increment(this string value, IIncrementor<string> incrementor)
        {
            return incrementor.Increment(value);
        }
    }
}