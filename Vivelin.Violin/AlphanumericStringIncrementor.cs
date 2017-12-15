using System;
using System.Collections.Generic;
using System.Text;

namespace Vivelin.Violin
{
    /// <summary>
    /// Determines the successor to a string by incrementing the last alphanumeric
    /// character in a string.
    /// </summary>
    public class AlphanumericStringIncrementor : IIncrementor<string>
    {
        /// <summary>
        /// A dictionary that maps the last characters in a sequence to the
        /// characters that start that sequence.
        /// </summary>
        private static readonly Dictionary<char, char> loopingCharacters = new Dictionary<char, char>
        {
            ['z'] = 'a',
            ['Z'] = 'A',
            ['9'] = '0',
        };

        /// <summary>
        /// Increments a value.
        /// </summary>
        /// <param name="value">The value to increment.</param>
        /// <returns>The successor to <paramref name="value"/>.</returns>
        public string Increment(string value)
        {
            var builder = new StringBuilder(value);
            for (var i = builder.Length - 1; i >= 0; i--)
            {
                if (IsLastCharacter(builder[i], out var next))
                {
                    builder[i] = next;
                    if (i == 0)
                    {
                        builder.Insert(0, next);
                        break;
                    }
                }
                else
                {
                    builder[i]++;
                    break;
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Determines whether a character is the last character in a sequence.
        /// </summary>
        /// <param name="c">The character to increment.</param>
        /// <param name="next">
        /// If <paramref name="c"/> is the last character in the sequence, returns
        /// the starting character in the sequence.
        /// </param>
        /// <returns>
        /// <c>true</c> if <paramref name="c"/> is the last character in a
        /// sequence; otherwise, <c>false</c>.
        /// </returns>
        private bool IsLastCharacter(char c, out char next)
        {
            if (loopingCharacters.ContainsKey(c))
            {
                next = loopingCharacters[c];
                return true;
            }

            next = default(char);
            return false;
        }
    }
}