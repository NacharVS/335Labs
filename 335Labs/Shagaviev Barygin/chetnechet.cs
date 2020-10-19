using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class chetnechet
    { 
         public static void Chisl()
        {
            string word = "вводное слово";
            int first = -1;
            int last = -1;
            foreach (char ch in word)
            {
                first = word.IndexOf(ch);
                last = word.LastIndexOf(ch);
                if (first != -1 && last != -1 && first != last)
                    word = word.Replace(ch.ToString(), "");
            }
            Console.Write(word);
            Console.ReadKey();
        }
    }
}
