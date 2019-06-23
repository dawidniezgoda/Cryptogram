using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptogram
{
    /// <summary>
    /// ROT13 class contains method to generate cipher.
    /// </summary>
    public static class Rot13
    {
        /// <summary>
        /// Transform method encrypts the text.
        /// </summary>
        /// <returns>
        /// The array of encrypted text.
        /// </returns>
        /// <param name="text">String of unencrypted characters.</param>
        public static string Transform(string text)
        {
            char[] array = text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
