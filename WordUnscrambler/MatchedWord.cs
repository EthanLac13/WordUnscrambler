using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    struct MatchedWord
    {
        public string ScrambledWord;
        public string Word;

        public string GetScrambledWord()
        {
            return this.ScrambledWord;
        }
        public void SetScrambledWord(string sw)
        {
            this.ScrambledWord = sw;
        }

        public string GetWord()
        {
            return this.Word;
        }
        public void SetWord(string w)
        {
            this.Word = w;
        }
    }
}
