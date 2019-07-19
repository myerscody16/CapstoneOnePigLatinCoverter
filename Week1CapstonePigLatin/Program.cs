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
                    Console.WriteLine($"{word}" + "-yay");
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
            //need to take in a word that starts with a consonant, then finds where a vowel is indexed at, saves the cluster of 
            //consonants that came before it, puts them, in order, in between "-" and "ay".
            int wordLength = word.Length;

            int Avowel = word.IndexOf('a');
            int Evowel = word.IndexOf('e');
            int Ivowel = word.IndexOf('i');
            int Ovowel = word.IndexOf('o');
            int Uvowel = word.IndexOf('u');
            //causes error because if a word doesnt have all of the vowels, the Xvowel variable returns a -1, making 
            //the minimum value -1 now, which causes an issue in the range of the clusters below.
            //**thought, we can make another method that sees if the value of the Xvowel variable is -1, if it is, make it ignored in the min() of the array.
            int[] vowelPlaceArray = { Avowel, Evowel, Ivowel, Ovowel, Uvowel };
            int vowelPlace = vowelPlaceArray.Min();

            //do stuff to make the stuff below work
            string consonantCluster = word.Substring(0, vowelPlace); 
            string letterFollowing1stVowel = word.Substring(vowelPlace, wordLength);
            Console.WriteLine($"{letterFollowing1stVowel}" + $"-{consonantCluster}ay");
        }
    }
}
