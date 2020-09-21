﻿using System;
using System.Collections.Generic;
using MorseCode.Entity;
using MorseCode.Service;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LatinAlphabetLexer latinAlphabetLexer = new LatinAlphabetLexer();

            string charsSequence, isQuit;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Wpisz tekst do przetłumaczenia na Kod Morse’a:");

                charsSequence = Console.ReadLine();

                charsSequence = "TeSt 123 te1st?TEST"; //TODO: remove

                List<Token> tokensList = latinAlphabetLexer.analizecCharsSequence(charsSequence);

                Console.WriteLine("\nDane wyjściowe lexera Twojego tekstu:\n");


                foreach(Token token in tokensList)
                {
                    Console.WriteLine(" index: {0}, type: {1}, argument: {2}", token.id, token.type, token.argument);
                }

                Console.WriteLine("\nCzy chcesz wyjść z programu? (y|N):");
                isQuit = Console.ReadLine();

                if(isQuit.ToLowerInvariant().Trim() == "y")
                {
                    break;
                }
            }

            Console.WriteLine("Dziękuje za skorzystanie z programu");
        }
    }
}
