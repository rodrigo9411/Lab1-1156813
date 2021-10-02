using System;

namespace Lab_1___1156813
{
    class Scanner
    {
        private string _regexp = "";
        private int _index = 0;

        public Scanner(string regexp)
        {
            _regexp = regexp + (char)TokenType.eof;
            _index = 0;
        }
        public Token GetToken()
        {
            Token result = new Token() { value = (char)0 };
            bool tokenFound = false;
            while (!tokenFound)
            {
                char peek = _regexp[_index];
                //Whitespace removal
                while (char.IsWhiteSpace(peek))
                {
                    _index++;
                    peek = _regexp[_index];
                }
                switch (peek)
                {
                    case (char)TokenType.lParen:
                    case (char)TokenType.rParen:
                    case (char)TokenType.plus:
                    case (char)TokenType.minus:
                    case (char)TokenType.mult:
                    case (char)TokenType.div:
                    case (char)TokenType.eof:
                        tokenFound = true;
                        result.tag = (TokenType)peek;
                        break;
                    default:
                        tokenFound = true;
                        result.tag = TokenType.number;
                        result.value = peek;
                        break;
                }
                _index++;
            }
            return result;

        }
    }
}
