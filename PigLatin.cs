using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndPuzzle
{
    public class PigLatin
    {
       public static void Translator()
        {
            Console.WriteLine(" Enter 1 to translate to Pig Latin ");
            Console.WriteLine(" ");
            Console.WriteLine(" Enter 2 to translate to English ");

            var Choice = Console.ReadLine();
            int choice;
            int.TryParse(Choice, out choice);
            int PigLatinSelectNumber = 1;
            int EnglishSelectNumber = 2;    
            List<string> pig = new List<string>();
            List<string> EnglishWord = new List<string>();
            if (choice == PigLatinSelectNumber)
            {
                Console.WriteLine("You Chose to translate to Pig Latin ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter English words");
                var word = Console.ReadLine();
                
                var WordArray = word.Trim().Split(" ");
                for (int i = 0; i < WordArray.Length; i++)
                {
                    var Pig = WordArray[i].Substring(1, WordArray[i].Length - 1) + WordArray[i].Substring(0, 1) + "ay";
                    
                    pig.Add(Pig);

                }
                string PigLatin = string.Join(" ", pig.ToArray());
                Console.WriteLine(" ");
                Console.WriteLine(PigLatin);
                Console.WriteLine(" ");
                ReTranslate();

            }
            else if (choice == EnglishSelectNumber)
            {
                Console.WriteLine("You Chose to translate to English ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter pig latin");
                int LeastStringLength = 3;
                var word = Console.ReadLine();
                var PigArray = word.Trim().Split(" ");
                for (int i = 0; i < PigArray.Length; i++)
                {
                    if (PigArray[i].Length >= LeastStringLength && PigArray[i].Substring(PigArray[i].Length - 2, 2) == "ay")
                    {
                        var word1 = PigArray[i].Substring(PigArray[i].Length - 3, 1) + PigArray[i].Substring(0, PigArray[i].Length - 3);
                        EnglishWord.Add(word1);
                    }
                    else
                    {
                        Console.WriteLine("Inappriopriate conversion");
                        Console.WriteLine(" ");
                        ReTranslate();
                    }

                }

                string FinalWord = string.Join(" ", EnglishWord.ToArray());
                Console.WriteLine(" ");
                Console.WriteLine(FinalWord);
                Console.WriteLine(" ");
                ReTranslate();
            }
            else
            {
                Console.WriteLine("Start again and choose a Valid Option!!");
                Console.WriteLine(" ");
                ReTranslate();
            }
        }
        internal static void ReTranslate()
        {
            Console.WriteLine("Enter 1 to translate again or any other key to exit");
            var choice = Console.ReadLine();
            if (int.TryParse(choice, out int choice1))
            {
                if (choice1 == 1)
                {
                    Translator();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
       
    }
}
