using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAndPuzzle
{
    public  class Encryptor
    {
        internal static void EncryptionOption()
        {
            var Alphabets = "abcdefghijklmnopqrstuvwxyz".Split();
            List<string> AlphabetList = Alphabets.ToList();
            var Keys = "£ * % & > <! ) \" ( @ a b c d e f g h i j k l m n o".Split();
            List<string> KeysList = Keys.ToList();
            string EncryptionOption = "E";
            string DecryptionOption = "D";
            Console.WriteLine("Welcome Choose Option: {0} to Encryt or Option " +
                "{1} to Decrypt or any other key to exit",EncryptionOption,DecryptionOption);

            string SelectedOption = Console.ReadLine();

            switch (SelectedOption)
            {
                case "E":
                    Console.WriteLine("Enter word to encrypt");
                    var rawWord = Console.ReadLine();
                    var wordList = rawWord.Trim().Split();
                    for (int i = 0; i < wordList.Length; i++)
                    {
                       // var index = AlphabetList.Contains(wordList[i]);
                        Console.WriteLine(wordList[i]);
                       //var key = KeysList[index];
                       // wordList[i] = key;
                    }
                    string encryptedWord = string.Join("",wordList.ToArray());

                    Console.WriteLine(encryptedWord);

                    break;

                case "D":

                    break;

                default:
                    return;
                    
            }
        }
        
    }
}
