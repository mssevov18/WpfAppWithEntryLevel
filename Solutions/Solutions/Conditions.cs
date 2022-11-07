using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
    public class _04 : IContainer
    {
        public string Title => $"04 Even or Odd";
        public string Statement =>
$"Problem Statement\r\n\r\nWrite a code which will check whether a given integer number is even or odd.\r\n\r\nHint: Think along the lines of using if-else condition.\r\n\r\nWrite your code below. It is recommended that you try solving the exercise yourself before viewing the solution.";
        public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18683";
        public string Solution =>
$"public bool IsEven(int num)\r\n{{\r\n\treturn num % 2 == 0;\r\n}}";
        public ArgumentCode[] Arguments => new ArgumentCode[]
        { new ArgumentCode(TypeCode.Int32, "Num") };

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public string RunSolution(params object[] args)
        {
            return IsEven((int)args[0]) ? "true" : "false";
        }
    }

    public class _05 : IContainer
    {
        public string Title => $"05 Implementing Calculator";
        public string Statement =>
$"Problem Statement\r\n\r\nWrite a code which will take:\r\n\r\nTwo float type variables named num1 and num2\r\n\r\na char type variable called Operator\r\n\r\nThe Operator variable can be passed the following:\r\n\r\n+,-,* and /\r\n\r\nUse switch statements to compute:\r\n\r\naddition,\r\n\r\nsubtraction,\r\n\r\nmultiplication\r\n\r\ndivision";
        public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18685";
        public string Solution =>
$"public double Calculate(double num1, double num2, char op)\r\n{{\r\n\tswitch(op)\r\n\t{{\r\n\t\tcase '+':\r\n\t\t\treturn num1 + num2;\r\n\t\tcase '-':\r\n\t\t\treturn num1 - num2;\r\n\t\tcase '*':\r\n\t\t\treturn num1 * num2;\r\n\t\tcase '/':\r\n\t\t\treturn num1 / num2;\r\n\t}}\r\n\treturn double.NaN;\r\n}}";
        public ArgumentCode[] Arguments => new ArgumentCode[]
        { new ArgumentCode(TypeCode.Double, "a"), 
          new ArgumentCode(TypeCode.Double, "b"), 
          new ArgumentCode(TypeCode.Char, "Operation") };

        public double Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            }
            return double.NaN;
        }

        public string RunSolution(params object[] args)
        {
            return Calculate((double)args[0], (double)args[1], (char)args[2]).ToString();
        }
    }
}
