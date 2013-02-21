//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by 
//performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Encryption
    {
        static void Main()
        {
            string text = "This is a top secret message!";
            string key = "password";
            Console.WriteLine(Encryptioned(text, key));
            Console.WriteLine(Decryptioned(Encryptioned(text, key), key));
        }
        static string Encryptioned(string text, string key)
        {
            char[] code = text.ToCharArray();
            char[] cipher = key.ToCharArray();
            StringBuilder crypted=new StringBuilder();
            int cycle = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (i>cipher.Length)
                {
                    cycle = 0;
                }
                crypted.Append((char)(code[i] ^ cipher[cycle]));
            }
            return crypted.ToString();
        }
        static string Decryptioned(string text, string key)
        {
            return Encryptioned(text, key);
        }
    }

