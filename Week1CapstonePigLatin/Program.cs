using System;

namespace Week1CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //if vowel starts word, then the word is just follow by -yay
            //if consonant starts word, that letter, and however many consonants that follow it
            //will be moved from the word and then is added to a hyphened part following the word, 
            //which is then followed by -ay.
            string[] wordArray = SplitSentences("Please input an English word or sentence for conversion to Pig Latin.");
            SplitWords(wordArray);
        }

        public static string[] SplitSentences(string message)
        {
            Console.WriteLine(message);
            string userSentence = Console.ReadLine();
            string[] wordArray = userSentence.Split(' ');
            return wordArray;

        }
        //use a method to break an array up into each word, then another method to break up into each letter
        public static void SplitWords(string[] wordArray)
        {
            foreach (string words in wordArray)
            {
                char[] letters = words.ToCharArray();
                if(letters[0] == 'a' || letters[0] == 'e' || letters[0] == 'i' || letters[0] == 'o' || letters[0] == 'u')
                {
                    Console.WriteLine($"{words}" + "-ay");
                }
                //else if statement that will take in a word that starts with a consonant and do something with it.
            }
        }

    }
}
