using System;
using System.Collections.Generic;
using MorseCode.Entity;

namespace MorseCode.Service
{
    public class LatinAlphabetLexer
    {
        public List<Token> analizecCharsSequence(string charsSequence)
        {
            List<Token> tokensList = new List<Token>();
            CharsDictionary charsDictionary = new CharsDictionary();

            for (int index = 0; index < charsSequence.Length; index++)
            {
                if(Char.IsWhiteSpace(charsSequence[index]))
                {
                    tokensList.Add(new Token(index, "SPACE", charsSequence[index].ToString()));
                }
                else if (charsDictionary.lettersDictionary.ContainsKey(Char.ToLower(charsSequence[index])))
                {
                    tokensList.Add(new Token(index, "LETTER", charsSequence[index].ToString()));
                }
                else if (charsDictionary.numbersDictionary.ContainsKey(charsSequence[index]))
                {
                    tokensList.Add(new Token(index, "NUMBER", charsSequence[index].ToString()));
                }
                else if (charsDictionary.symbolsDictionary.ContainsKey(charsSequence[index]))
                {
                    tokensList.Add(new Token(index, "SYMBOL", charsSequence[index].ToString()));
                }
            }

            return tokensList;
        }
    }
}
