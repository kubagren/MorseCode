using System;
using System.Collections.Generic;
using MorseCode.Entity;
using MorseCode.Service;

namespace MorseCode.Service
{
    public class LatinAlphabetParser
    {
        public string parseToMorseCode(List<Token> tokensList)
        {
            CharsDictionary charsDictionary = new CharsDictionary();

            string morseCode = "";

            foreach(Token token in tokensList)
            {
                if(morseCode.Length > 0)
                {
                    morseCode += " ";
                }

                switch(token.type)
                {
                    case "SPACE":
                        morseCode += "  ";
                        break;
                    case "LETTER":
                        morseCode += charsDictionary.lettersDictionary[token.argument.ToLower()];
                        break;
                    case "NUMBER":
                        morseCode += charsDictionary.numbersDictionary[token.argument];
                        break;
                    case "SYMBOL":
                        morseCode += charsDictionary.symbolsDictionary[token.argument];
                        break;
                }
            }

            return morseCode;
        }
    }
}
