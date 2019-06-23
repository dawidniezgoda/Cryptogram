using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptogram
{
    /// <summary>
    /// Caesar cipher class contains method to generate cipher.
    /// </summary>
    public static class Caesar_cipher
    {
        /// <summary>
        /// Transform method encrypts the text.
        /// </summary>
        /// <returns>
        /// String of encrypted text.
        /// </returns>
        /// <param name="text">String of unencrypted characters.</param>
        /// <param name="key">Integer value to encrypt text.</param>
        public static string Transform(int key, string text)
        {
            int size = text.Length;
            char[] value = new char[size];
            char[] cipher = new char[size];
            for (int i = 0; i < size; i++)
            {
                value[i] = Convert.ToChar(text.Substring(i, 1));
            }

            for (int i = 0; i < size; i++)
            {
                int count = 0;
                int a = Convert.ToInt32(value[i]);
                for (int j = 1; j <= key; j++)
                {
                    if (count == 0)
                    {
                        if (a == 90)
                        { a = 64; }
                        else if (a == 122)
                        { a = 96; }
                        cipher[i] = Convert.ToChar(a + j);
                        count++;
                    }
                    else
                    {
                        int b = Convert.ToInt32(cipher[i]);
                        if (b == 90)
                        { b = 64; }
                        else if (b == 122)
                        { b = 96; }
                        cipher[i] = Convert.ToChar(b + 1);

                    }
                }
            }
            string ciphertext = "";

            for (int i = 0; i < size; i++)
            {
                ciphertext = ciphertext + cipher[i].ToString();
            }

            return ciphertext;
        }
    }
}
