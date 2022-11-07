using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
	public class _09 : IContainer
	{
		public string Title => $"09 Pascal Triangle";

		public string Statement => $"Problem Statement\r\n\r\nThis is a C# exercise about using a two-dimensional array.\r\n\r\nWrite a C# program to display a table that represents a Pascal triangle of any size.\r\n\r\nPascal triangle\r\n\r\nIn Pascal triangle,\r\n\r\nfirst and the second rows are set to 1.\r\n\r\nEach element of the triangle (from the third row downward) is the sum of the element directly above it and the element to the left of the element directly above it.\r\n\r\nConsider the following example of a pascal triangle:\r\n\r\n\r\n\r\nYou’re given the PascalTriangle(int row) function in the code below.\r\n\r\nIt takes the given row and prints the corresponding Pascal Triangle.\r\n\r\nThe function is already declared; you just have to implement the logic.";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18701";

		public string Solution => $"public string PascalsTriangle(int height, int spacing)\r\n{{\r\n\tStringBuilder @string = new StringBuilder();\r\n\r\n\tint[,] data = new int[height, height];\r\n\r\n\tfor (int i = 0; i < height; i++)\r\n\t{{\r\n\t\tfor (int j = 0; j < height - i - 1; j++)\r\n\t\t\t@string.Append(\"\".PadRight(spacing / 2));\r\n\r\n\t\tfor (int k = 0; k <= i; k++)\r\n\t\t{{\r\n\t\t\tif (k == 0 || k == i)\r\n\t\t\t\tdata[i, k] = 1;\r\n\t\t\telse\r\n\t\t\t\tdata[i, k] = data[i - 1, k] + data[i - 1, k - 1];\r\n\t\t\t@string.Append(data[i, k].ToString().PadRight(spacing));\r\n\t\t}}\r\n\t\t@string.AppendLine();\r\n\t}}\r\n\treturn @string.ToString();\r\n}}";

		public ArgumentCode[] Arguments => new ArgumentCode[]
		{ new ArgumentCode(TypeCode.Int32, "Height"),
		  new ArgumentCode(TypeCode.Int32, "Padding") };

		public string PascalsTriangle(int height, int spacing)
		{
			StringBuilder @string = new StringBuilder();

			int[,] data = new int[height, height];

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < height - i - 1; j++)
					@string.Append("".PadRight(spacing / 2));

				for (int k = 0; k <= i; k++)
				{
					if (k == 0 || k == i)
						data[i, k] = 1;
					else
						data[i, k] = data[i - 1, k] + data[i - 1, k - 1];
					@string.Append(data[i, k].ToString().PadRight(spacing));
				}
				@string.AppendLine();
			}
			return @string.ToString();
		}

		public string RunSolution(params object[] args)
		{
			return PascalsTriangle((int)args[0], (int)args[1]);
		}
	}

	public class _10 : IContainer
	{
		public string Title => "10 Making Matrix Using Arrays";

		public string Statement => $"Problem Statement\r\n\r\nIn this C# exercise, you’re are about to write C# program to display the matrix shown below by using a two-dimensional array.\r\n\r\n\r\n\r\nThe diagonal of the matrix should be filled with 0.\r\n\r\nThe lower side should be filled will -1s.\r\n\r\nupper side should be filled with 1s.";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18703";

		public string Solution => $"public string CreateMatrix(int size, int padding)\r\n{{\r\n\tStringBuilder @string = new StringBuilder();\r\n\r\n\tfor (int y = 0; y < size; y++)\r\n\t{{\r\n\t\tfor (int x = 0; x < size; x++)\t\t\t\t\r\n\t\t\t@string.Append(x == 0 ? \r\n\t\t\t\t$\"{{(x == y ? \" 0\" : (x > y) ? \" 1\" : \"-1\")}}\" : \r\n\t\t\t\t$\"{{(x == y ? \" 0\" : (x > y) ? \" 1\" : \"-1\")}}\".PadLeft(padding));\r\n\t\t@string.AppendLine();\r\n\t}}\r\n\r\n\treturn @string.ToString();\r\n}}";

		public ArgumentCode[] Arguments => new ArgumentCode[]
		{ new ArgumentCode(TypeCode.Int32, "Size"),
		  new ArgumentCode(TypeCode.Int32, "Padding") };

		public string CreateMatrix(int size, int padding)
		{
			StringBuilder @string = new StringBuilder();

			for (int y = 0; y < size; y++)
			{
				for (int x = 0; x < size; x++)				
					@string.Append(x == 0 ? 
						$"{(x == y ? " 0" : (x > y) ? " 1" : "-1")}" : 
						$"{(x == y ? " 0" : (x > y) ? " 1" : "-1")}".PadLeft(padding));
				@string.AppendLine();
			}

			return @string.ToString();
		}

		public string RunSolution(params object[] args)
		{
			return CreateMatrix((int)args[0], (int)args[1]);
		}
	}

	public class _11 : IContainer
	{
		public string Title => "11 Display the Unique Elements";

		public string Statement => $"Problem Statement\r\n\r\nYou have to implement the function findUnique() which, as the name suggests, finds and prints out the unique elements from the given array, separated by a space character.\r\n\r\nExample Input\r\n\r\nint[] input1 = new int[10] {{3, 5, 2, 7, 7, 4, 1, 5, 7, 2}}\r\n\r\nExample Output\r\n\r\n3 4 1";

		public string Link => $"https://codingburgas.org/mod/assign/view.php?id=18705";

		public string Solution => $"public string FindUnique(int[] arr)\r\n{{\r\n\tStringBuilder @string = new StringBuilder();\r\n\tList<int> unique = new List<int>();\r\n\r\n\tforeach (int num in arr)\r\n\t\tif (!unique.Contains(num))\r\n\t\t\tunique.Add(num);\r\n\r\n\tforeach (int num in unique)\r\n\t\t@string.Append($\"{{num}}, \");\r\n\r\n\t@string.Remove(@string.Length - 2, 2);\r\n\r\n\treturn @string.ToString();\r\n}}";

		public ArgumentCode[] Arguments => new ArgumentCode[]
		{
			new ArgumentCode(TypeCode.Int32, "a[0]"),
			new ArgumentCode(TypeCode.Int32, "a[1]"),
			new ArgumentCode(TypeCode.Int32, "a[2]"),
			new ArgumentCode(TypeCode.Int32, "a[3]"),
			new ArgumentCode(TypeCode.Int32, "a[4]"),
			new ArgumentCode(TypeCode.Int32, "a[5]"),
		};

		public string FindUnique(int[] arr)
		{
			StringBuilder @string = new StringBuilder();
			List<int> unique = new List<int>();

			foreach (int num in arr)
				if (!unique.Contains(num))
					unique.Add(num);

			foreach (int num in unique)
				@string.Append($"{num}, ");

			@string.Remove(@string.Length - 2, 2);

			return @string.ToString();
		}

		public string RunSolution(params object[] args)
		{
			return FindUnique(new int[] {
				(int)args[0], 
				(int)args[1], 
				(int)args[2], 
				(int)args[3], 
				(int)args[4], 
				(int)args[5], 
			});
		}
	}
}
