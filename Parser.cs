using System;

namespace Lab_1___1156813
{
    class Parser
    {
        Scanner _scanner;
        Token _token;

        private void E()
        {
            switch (_token.tag)
            {
                case TokenType.lParen:
                case TokenType.empty:
                case TokenType._null:
                case TokenType.number:
                case TokenType.minus:
                    T();
                    EP();
                    break;
                default:
                    break;
            }
        }

        private void EP()
        {
            switch (_token.tag)
            {
                case TokenType.plus:
                case TokenType.minus:
                    Match(_token.tag);
                    T();
                    EP();
                    break;

                default:
                    break;
            }
        }

        private void T()
        {
            F();
            TP();
        }

        private void TP()
        {
            switch (_token.tag)
            {
                case TokenType.mult:
                case TokenType.div:
                    Match(_token.tag);
                    F();
                    TP();
                    break;

                default:
                    break;
            }
        }

        private void F()
        {
            switch (_token.tag)
            {
                case TokenType.lParen:
                    Match(TokenType.lParen);
                    E();
                    Match(TokenType.rParen);
                    break;
                case TokenType.number:
                case TokenType._null:
                case TokenType.empty:
                    Match(_token.tag);
                    break;
                case TokenType.minus:
                    Match(TokenType.minus);
                    F();
                    break;
                default:
                    throw new Exception("Error de Sintaxis");
            }
        }





        private void Match(TokenType tag)
        {
            if (_token.tag == tag)
            {
                _token = _scanner.GetToken();

            }
            else
            {
                throw new Exception("Error de Sintaxis");
            }

        }

        public void Parse(string regexp)
        {
            _scanner = new Scanner(regexp + (char)TokenType.eof);
            _token = _scanner.GetToken();
            switch (_token.tag)
            {
                case TokenType.lParen:
                case TokenType.empty:
                case TokenType._null:
                case TokenType.number:
                case TokenType.minus:
                    E();
                    break;
                default:
                    break;
            }
            Match(TokenType.eof);

        } // Parse
    } //Parser
}
