using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solutions
{
	public struct ArgumentCode
	{
		public ArgumentCode(TypeCode type, string name) : this()
		{
			Type = type;
			Name = name;
		}

		public TypeCode Type { get; set; }
		public string Name { get; set; }
	}

	public static class TypeCodeEx
	{
		public static object GetDefaultValue(TypeCode typeCode)
		{
			switch (typeCode)
			{
				case TypeCode.Int32:
					return 5;
				case TypeCode.Boolean:
					return true;
				case TypeCode.Char:
					return 'n';
				case TypeCode.String:
					return "Lorem";
				case TypeCode.Double:
					return 13.5d;
				case TypeCode.Object:
					return null;
			}
			return null;
		}
	}
}
