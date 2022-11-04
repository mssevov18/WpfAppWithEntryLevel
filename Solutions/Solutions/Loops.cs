using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
	public class _06 : IContainer
	{
		public string Title => "06 Multiplication table";

		public string Statement => $"Problem Statement\r\n\r\nWrite a code which will\r\n\r\nPrint the multiplication table of a number up to 10.\r\n\r\nYou have to use do-while loop for solving this problem.\r\n\r\nYour code should return the string ans with all the values computed from multiplication appended in that string.\r\n\r\nHere’s a link showing how you can add values to a string.\r\n\r\nExample\r\n\r\nInput: int num = 5\r\n\r\nHere’s an illustration showing what the string ans should have stored in it at the end of the do-while loop for the above mentioned input.\r\n\r\n\r\n\r\nNote Just like it is shown in the picture above, the values in the string should have spaces in between them. You can add a space by simply adding quotation marks with space in between them to your string, like this: \" \".\r\n\r\nIn your code also display the values after multiplying the number up to 10 as shown in the picture below.\r\n\r\n";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18692";

		public string Solution => $"public string Multiply(int num)\r\n{{\r\n\tStringBuilder @string = new StringBuilder();\r\n\r\n\tfor (int i = 1; i < 10; i++)\r\n\t\t@string.AppendLine($\"{{num}} x {{i}} = {{num*i}}\");\r\n\r\n\treturn @string.ToString();\r\n}}";

		public TypeCode[] Arguments => new TypeCode[] { TypeCode.Int32 };

		public string Multiply(int num)
		{
			StringBuilder @string = new StringBuilder();

			for (int i = 1; i <= 10; i++)
				@string.AppendLine($"{num} x {i} = {num * i}");

			return @string.ToString();
		}

		public string RunSolution(params object[] args)
		{
			return Multiply((int)args[0]);
		}
	}

	public class _07 : IContainer
	{
		public string Title => $"07 Fibonacci Sequence upto n Number Of Terms";

		public string Statement => $"Problem Statement\r\n\r\nIn this exercise, you have to write Fibonacci Sequence of a given number.\r\n\r\nYou have to print the sequence up to the given range which is passed as a parameter to the test method.\r\n\r\nYour code should return the string variable ans which will have all the Fibonacci values computed upto the given range appended in that string.\r\n\r\nHere’s a link showing how you can add values to a string.\r\n\r\nExample\r\n\r\nIf the value of range is 6.\r\n\r\nThen ans should have the following stored in it at the end of the method:\r\n\r\n\r\n\r\nDisplay the output above in the console as well.\r\n\r\nNote Just like it is shown in the picture above, the values in the string should have spaces in between them. You can add a space by simply adding quotation marks with space in between them to your string, like this: \" \".\r\n\r\n";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18694";

		public string Solution => $"private StringBuilder @string;\r\npublic void Fibonacci(int firstnumber, int secondnumber,\r\n\t\t\t\t\t\t\t\tint count, int length)\r\n{{\r\n\tif (firstnumber > length)\r\n\t\treturn;\r\n\tif (count <= length)\r\n\t{{\r\n\t\t@string.Append($\"{{firstnumber}} \");\r\n\t\tFibonacci(secondnumber, firstnumber + secondnumber, count + 1, length);\r\n\t}}\r\n}}";

		public TypeCode[] Arguments => new TypeCode[] { TypeCode.Int32 };

		private StringBuilder @string;
		public void Fibonacci(int firstnumber, int secondnumber,
										int count, int length)
		{
			if (firstnumber > length)
				return;
			if (count <= length)
			{
				@string.Append($"{firstnumber} ");
				Fibonacci(secondnumber, firstnumber + secondnumber, count + 1, length);
			}
		}

		public string RunSolution(params object[] args)
		{
			@string = new StringBuilder();
			Fibonacci(0, 1, 1, (int)args[0]);
			return @string.ToString();
		}
	}

	public class _08 : IContainer
	{
		public string Title => $"08 Pyramid Printing By Using For Loop";

		public string Statement => $"Problem Statement\r\n\r\nWrite code which prints half a pyramid of the alphabet a.\r\n\r\nThe method takes an integer variable rows as input and prints the pyramid with that number of rows displaying a.\r\n\r\nHint: Use for loops to implement the solution.\r\n\r\nExample\r\n\r\nInput\r\n\r\nrows is equal to 5.";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18697";

		public string Solution => $"public string PyramidBuilder(int num)\r\n{{\r\n\tStringBuilder @string = new StringBuilder();\r\n\r\n\tfor (int i = 1; i <= num; i++)\r\n\t\t@string.AppendLine(new string('a', i));\r\n\r\n\treturn @string.ToString();\r\n}}";

		public TypeCode[] Arguments => new TypeCode[] { TypeCode.Int32 };

		public string PyramidBuilder(int num)
		{
			StringBuilder @string = new StringBuilder();

			for (int i = 1; i <= num; i++)
				@string.AppendLine(new string('a', i));

			return @string.ToString();
		}

		public string RunSolution(params object[] args)
		{
			return PyramidBuilder((int)args[0]);
		}
	}
}
