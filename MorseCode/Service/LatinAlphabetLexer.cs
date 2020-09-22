using System;
using System.Collections.Generic;
using MorseCode.Const;
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
                string currentChar = charsSequence[index].ToString();

                if (Char.IsWhiteSpace(charsSequence[index]))
                {
                    tokensList.Add(new Token(index, TokenTypes.SPACE, currentChar));
                }
                else if (charsDictionary.lettersDictionary.ContainsKey(currentChar.ToLower()))
                {
                    tokensList.Add(new Token(index, TokenTypes.LETTER, currentChar));
                }
                else if (charsDictionary.numbersDictionary.ContainsKey(currentChar))
                {
                    tokensList.Add(new Token(index, TokenTypes.NUMBER, currentChar));
                }
                else if (charsDictionary.symbolsDictionary.ContainsKey(currentChar))
                {
                    tokensList.Add(new Token(index, TokenTypes.SYMBOL, currentChar));
                }
            }

            return tokensList;
        }
    }
}
