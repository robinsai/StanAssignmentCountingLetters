using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicee
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a contains function
            string increaseArray(string array)
            {
                string biggerSentence = "";
                for (int i = 0; i < array.Length; i++)
                {
                    biggerSentence += array[i];
                }

                return biggerSentence;

            }
            //take in string. ex: "Cat In The Hat!!!" 
            //Count how many of each character is in the string
            Console.WriteLine("type in a sentence and i will display all the letters used(and symbols) and tell you how many times it has popped up");
            int howManyTimes = 0;
            string sentence = Console.ReadLine();
            string letters = "";
            letters += sentence[0];
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int x = 0; x < letters.Length; x++)
                {
                    if (letters[x] != sentence[i] )
                    {

                        letters += sentence[i];

                    }
                }
            }
            Console.WriteLine(letters);
            Console.ReadKey();
            /*
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]}");
            }
            Console.ReadKey();*/
        }
    }
}
