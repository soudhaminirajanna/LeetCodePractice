using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class InfixPostFixExpression
    {
        public string InfixTOPostfix(string infix)
        {
            Stack<char> S = new Stack<char>();
            List<char> postfix = new List<char>();
            var infixexp = infix.ToCharArray();
            foreach (char i in infixexp)
            {
                if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
                {
                    postfix.Add(i);
                }
                else if (isOperator(i))
                {
                    while (S.Any() && precedence(S.Peek()) >= precedence(i))
                    {
                        postfix.Add(S.Pop());
                    }
                    S.Push(i);
                }
                else if (i == '(')
                {
                    S.Push(i);
                }
                else if (i == ')')
                {
                    while (S.Any() && S.Peek() != '(')
                    {
                        postfix.Add(S.Pop());
                    }
                    S.Pop();
                }
            }
            while (S.Any())
            {
                postfix.Add(S.Pop());
            }
            return postfix.ToString();
        }
        private int precedence(char peek)
        {
            var pre = 0;
            switch (peek)
            {
                case '+': pre = 1; break;
                case '-': pre = 1; break;
                case '*': pre = 2; break;
                case '/': pre = 2; break;
            }
            return pre;
        }

        private bool isOperator(char i)
        {
            if (i == '+' || i == '*' || i == '-' || i == '/')
                return true;
            else return false;
        }

    }
}
