using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_actions_demo
{
    public static class Calculator
    {
        // calculate result of string eg 1 + 2
        public static double Calculate(string input)
        {
            // split string into array of strings
            string[] split = input.Split(' ');

            // create stack to store numbers
            Stack<double> stack = new Stack<double>();

            // loop through array of strings
            for (int i = 0; i < split.Length; i++)
            {
                // if string is a number
                if (double.TryParse(split[i], out double num))
                {
                    // push number to stack
                    stack.Push(num);
                }
                // if string is an operator
                else if (IsOperator(split[i]))
                {
                    // if stack has less than 2 numbers
                    if (stack.Count < 2)
                    {
                        // throw exception
                        throw new InvalidOperationException("Invalid expression");
                    }

                    // pop 2 numbers from stack
                    double a = stack.Pop();
                    double b = stack.Pop();

                    // calculate result of operation
                    double result = Calculate(b, a, split[i]);

                    // push result to stack
                    stack.Push(result);
                }
                // if string is not a number or operator
                else
                {
                    // throw exception
                    throw new InvalidOperationException("Invalid expression");
                }
            }

            // if stack has more than 1 number
            if (stack.Count > 1)
            {
                // throw exception
                throw new InvalidOperationException("Invalid expression");
            }

            // return result
            return stack.Pop();
        }

        // calculate result of operation
        private static double Calculate(double a, double b, string op)
        {
            // switch on operator
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                case "^":
                    return Math.Pow(a, b);
                default:
                    throw new InvalidOperationException("Invalid expression");
            }
        }
        
        // check if string is an operator
        public static bool IsOperator(string op)
        {
            // switch on operator
            switch (op)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                    return true;
                default:
                    return false;
            }
        }
    }
}