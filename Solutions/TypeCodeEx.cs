using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
	public static class TypeCodeEx
	{
		public static object GetDefaultValue(TypeCode typeCode)
		{
			switch(typeCode)
			{
				case TypeCode.Int32:
					return 72;
				case TypeCode.Boolean:
					return true;
				case TypeCode.Char:
					return 'n';
				case TypeCode.String:
					return "Lorem";
				case TypeCode.Double:
					return 13.5d;
			}
			return null;
		}
	}
}
