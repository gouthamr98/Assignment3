using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class assignment3
    {
        public static void Main(string[] args)
        {
            string word = "hai goutham how are you";
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                }
                    
            }

            Console.WriteLine("String is :" + word);
            Console.Write("No.of spaces = " + count);
            Console.ReadLine();
        }
    }
}
