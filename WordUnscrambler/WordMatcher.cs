using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();
            String str1, str2;

            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                
                    //Console.Write("{0} and {1}: ", scrambledWord, word);
                    str1 = String.Concat(scrambledWord.OrderBy(c => c));
                    str2 = String.Concat(word.OrderBy(c => c));
                    //scrambledWord already matches word
                    if (str1.Equals(str2)) {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        //Console.WriteLine("The two words match.");
                    }
                    else
                    {
                        //Console.WriteLine("The two words don't match.");
                    }
                }
            }

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }

            return matchedWords;
        } 
    }

}
