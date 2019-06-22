using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptogram
{
    class Hexadecimal
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string alphabet2 = "abcdefghijklmnopqrstuvwxyz";
        public static string Transform(string text)
        {
            string cipher = "";
            int number;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    cipher += ' ';

                for (int j = 0; j < 26; j++)
                {

                    if (text[i] == alphabet[j])
                    {
                        number = j + 65;
                        cipher += Convert.ToString(number, 16);
                    }
                    else if (text[i] == alphabet2[j])
                    {
                        number = j + 97;
                        cipher += Convert.ToString(number, 16);
                    }
                }
            }
            return cipher;
        }
    }
}
