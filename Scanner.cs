using System;

namespace Lab_1___1156813
{
    class Scanner
    {
        private string _regexp = "";
        private int _index = 0;
        private int _state = 0;
        public Scanner(string regexp)
        {
            _regexp = regexp + (char)TokenType.eof;
            _index = 0;
            _state = 0;
        }
        public Token GetToken()
        {
            Token result = new Token() { value = (char)0 };
            bool tokenFound = false;
            while (!tokenFound)
            {
                char peek = _regexp[_index];
                switch (_state)
                {
                    case 0:

                        //Whitespace removal
                        while (char.IsWhiteSpace(peek))
                        {
                            _index++;
                            peek = _regexp[_index];
                        }
                        switch (peek)
                        {
                            case '\\':
                                _state = 1;
                                break;
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
                        break;
                    case 1:
                        switch (peek)
                        {
                            case (char)TokenType.lParen:
                            case (char)TokenType.rParen:
                            case (char)TokenType.plus:
                            case (char)TokenType.minus:
                            case (char)TokenType.mult:
                            case (char)TokenType.div:
                            case (char)TokenType.eof:
                            case '\\':
                            case ' ':
                                tokenFound = true;
                                result.tag = TokenType.number;
                                result.value = peek;
                                break;
                            case 'E':
                                tokenFound = true;
                                result.tag = TokenType._null;
                                break;
                            case '0':
                                tokenFound = true;
                                result.tag = TokenType.empty;
                                break;

                            default:
                                throw new Exception("Lex Error");
                        }
                        break;
                    default:
                        break;
                }
                _index++;
            }
            _state = 0;
            return result;

        }
    }
}
