using System;

namespace Week1CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordArray = SplitSentences("Please input an English word or sentence for conversion to Pig Latin, then press enter.");
            foreach (string word in wordArray)
            {
                string consWord = "";
                char[] charArray = word.ToCharArray();
                if(charArray[0] == 'a' || charArray[0] == 'e' || charArray[0] == 'i' || charArray[0] == 'o' || charArray[0] == 'u')
                {
                    Console.WriteLine($"{word}" + "-yay");
                }
                else
                {
                    consWord = word;
                    string pigLatinConsWord = HandleConsWords(consWord);
                    Console.WriteLine(pigLatinConsWord);
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
        public static string HandleConsWords(string consWord)
        {
            //need to take in a word that starts with a consonant, then finds where a vowel is indexed at, saves the cluster of 
            //consonants that came before it, puts them, in order, in between "-" and "ay".
            int Avowel = consWord.IndexOf('a');
            int Evowel = consWord.IndexOf('e');
            int Ivowel = consWord.IndexOf('i');
            int Ovowel = consWord.IndexOf('o');
            int Uvowel = consWord.IndexOf('u');

        }
    }
}
