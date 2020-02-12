using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerCrypt
{
    public class Vigener
    {
        /// <summary>
        /// All allowed characters
        /// </summary>
        public const string Characters = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$%&'()@*+,-./:;<=>?![\\]^_`{|}\"~";

        public string Encrypt(string input, string password)
        {
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                char p = password[i % password.Length];

                if (!Characters.Contains(c) || !Characters.Contains(p))
                    output += c;
                else
                {
                    int index = Characters.IndexOf(c) + Characters.IndexOf(p) + 1;
                    
                    if (index >= Characters.Length)
                        index -= Characters.Length;

                    output += Characters[index];
                }
            }

            return output;
        }

        public string Decrypt(string input, string password)
        {
            string output = null;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                char p = password[i % password.Length];

                if (!Characters.Contains(c) || !Characters.Contains(p))
                    output += c;
                else
                {
                    int index = Characters.IndexOf(c) - Characters.IndexOf(p) - 1;

                    if (index < 0)
                        index += Characters.Length;

                    output += Characters[index];
                }
            }

            return output;
        }
    }
}
