using System;

namespace MorseCode.Entity
{
    public class Token
    {
        public int id { get; set; }
        public string type { get; set; }
        public string argument { get; set; }

        public Token(int tokenId, string tokenType, string tokenArgument)
        {
            id = tokenId;
            type = tokenType;
            argument = tokenArgument;
        }
    }
}
