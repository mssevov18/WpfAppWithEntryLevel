using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
    public class _01 : IContainer
    {
        public string Title => $"01 Declaration and Initialization Of Data Types";
        public string Statement =>
$"Declare an integer type variable name intNumber and assign it a value of 30." +
$"\nDeclare a float type variable name floatNumber and assign it a value of 30.78." +
$"\nDeclare a double type variable name doubleNumber and assign it a value of 45.1234." +
$"\nDeclare a bool type variable name boolean and assign it a value of true." +
$"\nDeclare a char type variable name charName and assign it a value of u." +
$"\nLastly, print the values of all declared variables.";
        public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18675";
        public string Solution =>
$"int intNumber = 30;" +
$"\nfloat floatNumber = 30.78f;" +
$"\ndouble doubleNumber = 45.1234d;" +
$"\nbool boolean = true;" +
$"\nchar charName = 'u';" +
$"\nConsole.WriteLine($\"{{intNumber}}, {{floatNumber}}, {{doubleNumber}}, {{boolean}}, {{charName}}\");";
        public ArgumentCode[] Arguments => null;

        public string RunSolution(params object[] args)
        {
            int intNumber = 30;
            float floatNumber = 30.78f;
            double doubleNumber = 45.1234d;
            bool boolean = true;
            char charName = 'u';

            return $"{intNumber}, {floatNumber}, {doubleNumber}, {boolean}, {charName}";
        }
    }
}
