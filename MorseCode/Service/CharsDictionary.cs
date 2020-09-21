using System;
using System.Collections.Generic;

namespace MorseCode.Service
{
    public class CharsDictionary
    {
        public Dictionary<char, string> lettersDictionary { get; set; }
        public Dictionary<char, string> numbersDictionary { get; set; }
        public Dictionary<char, string> symbolsDictionary { get; set; }

        public CharsDictionary()
        {
            lettersDictionary = new Dictionary<char, string>()
            {
                { 'a', ".-" },
                { 'b', "-..." },
                { 'c', "-.-." },
                { 'd', "-.." },
                { 'e', "." },
                { 'f', "..-." },
                { 'g', "--." },
                { 'h', "...." },
                { 'i', ".." },
                { 'j', ".---" },
                { 'k', "-.-" },
                { 'l', ".-.." },
                { 'm', "--" },
                { 'n', "-." },
                { 'o', "---" },
                { 'p', ".--." },
                { 'q', "--.-" },
                { 'r', ".-." },
                { 's', "..." },
                { 't', "-" },
                { 'u', "..-" },
                { 'v', "...-" },
                { 'w', ".--" },
                { 'x', "-..-" },
                { 'y', "-.--" },
                { 'z', "--.." },
                { 'ą', ".-.-" },
                { 'ć', "-.-.." },
                { 'ę', "..-.." },
                { 'é', "..-.." },
                { 'ł', ".-..-" },
                { 'ń', "--.--" },
                { 'ó', "---." },
                { 'ś', "...-..." },
                { 'ż', "--..-." },
                { 'ź', "--..-" }
            };

            numbersDictionary = new Dictionary<char, string>()
            {
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                { '0', "-----" }
            };

            symbolsDictionary = new Dictionary<char, string>()
            {
                { '.', ".-.-.-" },
                { ',', "--..--" },
                { '\'', ".----." },
                { '"', ".-..-." },
                { '_', "..--.-" },
                { ':', "---..." },
                { ';', "-.-.-." },
                { '?', "..--.." },
                { '!', "-.-.--" },
                { '-', "-....-" },
                { '+', ".-.-." },
                { '/', "-..-." },
                { '(', "-.--." },
                { ')', "-.--.-" },
                { '=', "-...-" },
                { '@', ".--.-." }
            };
        }
    }
}