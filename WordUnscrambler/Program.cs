using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
          
            bool keepGoing = true;
            while(keepGoing)
            {  
                try
                {
                    
                    Console.WriteLine(ProgramConstants.PROMPT1);

                    String option = Console.ReadLine() ?? throw new Exception(ProgramConstants.PROMPT2);
                
                    switch (option.ToUpper())
                    {
                        case "F":
                            Console.WriteLine(ProgramConstants.PROMPT3);
                            ExecuteScrambledWordsInFileScenario();
                            break;
                        case "M":
                            Console.WriteLine(ProgramConstants.PROMPT4);
                            ExecuteScrambledWordsManualEntryScenario();
                            break;
                        default:
                            Console.WriteLine(ProgramConstants.PROMPT5);
                            break;
                    }

                        //Console.ReadLine();


                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ProgramConstants.PROMPT6 + ex.Message);
                    keepGoing = false;
                }
            }
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            var filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {

            List<string> scrambledWords= new List<string>();
            string str = "";
                
               
                  
                    Console.WriteLine(ProgramConstants.PROMPT7);
                    str = Console.ReadLine();
                    
                    scrambledWords.Add(str);
                   

            string[] scrambledWordsarray = scrambledWords.ToArray();
            str = str.Replace(" ", "");
            scrambledWordsarray = str.Split(',');
        

            DisplayMatchedUnscrambledWords1(scrambledWordsarray);

        }


         
    

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            
      


            
            foreach (var matchedWord in matchedWords)
            {
                Console.WriteLine(ProgramConstants.PROMPT8, matchedWord.GetScrambledWord(), matchedWord.GetWord());
            }
        }

        private static void DisplayMatchedUnscrambledWords1(string[] scrambledWordsarray)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWordsarray, wordList);






            foreach (var matchedWord in matchedWords)
            {
                Console.WriteLine("Match: {0} unscrambles to {1}.", matchedWord.GetScrambledWord(), matchedWord.GetWord());
            }
        }
    }
}
