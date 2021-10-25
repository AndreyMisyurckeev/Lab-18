using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Sample = "([]{})[]";
            Console.WriteLine(Temlate(Sample));
            Console.ReadKey();
        }
        public static bool Temlate(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    continue;
                }
                if (c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }

                if (c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }

                if (c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}