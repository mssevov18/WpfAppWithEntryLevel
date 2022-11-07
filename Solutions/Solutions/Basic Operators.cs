using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
    public class _02 : IContainer
    {
        public string Title => $"02 Computing an Expression using Logic";
        public string Statement =>
$"Problem Statement" +
$"\nThere’s always some logic in whatever we do, whether it seems like that or not. This time, we are going to give you the logic and all you need to do is implement it. The challenge is to create the expression explained below and find what result it gives!" +
$"\n\nCoding Exercise" +
$"\nThe first step is done for you, which is the method. The method takes in two variables and computes a logical expression using them. For explanation’s sake, the parameters are called x and y." +
$"\nNow you must do the following:" +
$"\nFind the Boolean NOT of x" +
$"\nBoolean XOR this with x itself" +
$"\nFind the Boolean AND of this answer with y" +
$"\nReturn the Boolean NOT of the entire expression" +
$"\nOnly write the code where instructed in the snippet below. The return statement and the variable to be returned are already mentioned for you." +
$"\n\nImportant Note: Since we are returning true by default in the code below when you run the code without writing the solution it will still pass two of our test cases. However, your code needs to pass ALL four of our test cases in order to be considered correct.";
        public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18678";
        public string Solution =>
$"public int BooleanOp(int x, int y)" +
 "\n{" +
$"\n	return ~((x ^ (~x)) & y);" +
 "\n}";
        public ArgumentCode[] Arguments => new ArgumentCode[]
        { new ArgumentCode(TypeCode.Int32, "X"),
          new ArgumentCode(TypeCode.Int32, "Y") };

        public int BooleanOp(int x, int y)
        {
            return ~((x ^ ~x) & y);
        }

        public string RunSolution(params object[] args)
        {
            int x = (int)args[0], y = (int)args[1];
            return $"~(({x} ^ (~{x})) & {y}) = {BooleanOp(x, y)}";
        }
    }

    public class _03 : IContainer
    {
        public string Title => $"03 Computing Binomial Expression";

        public string Statement =>
$"Problem Statement" +
$"\nWrite code for computing the formula" +
$"\n(a+b)^2" +
$"\nwhich expands into the following expression:" +
$"\n\nIn your code:" +
$"\nCompute squares of double type variables a and b." +
$"\nCompute the product 2*a*b" +
$"\nThen Add the squares and the product together." +
$"\nUse Math.Pow library to compute the squares of tha variables a and b.";

        public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18680&forceview=1";

        public string Solution =>
$"public double SolveBinom(double a, double b)" +
"\n{" +
$"\n	return a * a + 2 * a * b + b * b;" +
"\n}";
        public ArgumentCode[] Arguments => new ArgumentCode[]
        { new ArgumentCode(TypeCode.Double, "a"),
          new ArgumentCode(TypeCode.Double, "b") };

        public double SolveBinom(double a, double b)
        {
            return a * a + 2 * a * b + b * b;
        }

        public string RunSolution(params object[] args)
        {
            double a = (double)args[0], b = (double)args[1];
            return $"{a}^2 + 2*{a}*{b} + {b}^2 = {SolveBinom(a, b)}";
        }
    }
}
