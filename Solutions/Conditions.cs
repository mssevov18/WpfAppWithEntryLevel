using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
	public class _04 : IContainer
	{
		public string Title => $"04 Even or Odd";
		public string Statement =>
$"Problem Statement\r\n\r\nWrite a code which will check whether a given integer number is even or odd.\r\n\r\nHint: Think along the lines of using if-else condition.\r\n\r\nWrite your code below. It is recommended that you try solving the exercise yourself before viewing the solution.";
		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18683";
		public string Solution =>
$"public bool IsEven(int num)\r\n{{\r\n\treturn num % 2 == 0;\r\n}}";
		public TypeCode[] Arguments => new TypeCode[] { TypeCode.Int32 };

		public bool IsEven(int num)
		{
			return num % 2 == 0;
		}

		public string RunSolution(params object[] args)
		{
			return (IsEven((int)args[0])) ? "true" : "false";
		}
	}
}
