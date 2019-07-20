using System;
using System.Linq;

namespace Week1CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordArray = SplitSentences("Please input an English word or sentence for conversion to Pig Latin, then press enter.");
            foreach (string word in wordArray)
            {
                char[] charArray = word.ToCharArray();
                if(charArray[0] == 'a' || charArray[0] == 'e' || charArray[0] == 'i' || charArray[0] == 'o' || charArray[0] == 'u')
                {
                    Console.WriteLine("\n" + $"{word}" + "-yay");
                }
                else
                {
                    HandleConsWords(word);
                }
            }
            
        }

        public static string[] SplitSentences(string message)
        {
            Console.WriteLine(message);
            string userSentence = Console.ReadLine().ToLower();
            string[] wordArray = userSentence.Split(' ');
            return wordArray;

        }
        public static void HandleConsWords(string word)
        {
            int wordLength = word.Length;
            int Avowel = word.IndexOf('a');
            int Evowel = word.IndexOf('e');
            int Ivowel = word.IndexOf('i');
            int Ovowel = word.IndexOf('o');
            int Uvowel = word.IndexOf('u');

            int[] vowelPlaceArray = {Avowel, Evowel, Ivowel, Ovowel, Uvowel};

            int[] minValArray = vowelPlaceArray.Where(x => x > 0).ToArray();
            int minVal = minValArray.Min();
            string consonantCluster = word.Substring(0, minVal);
            string letterFollowing1stVowel = word.Substring(minVal, wordLength-minVal);
            Console.WriteLine("\n" + $"{letterFollowing1stVowel}" + $"-{consonantCluster}ay");

        }
    }
}
