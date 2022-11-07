using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Solutions
{
	public class Info : IContainer
	{
		public string Title => "Info";

		public string Statement => $"This project was made by mssevov18.";

		public string Link => $"https://github.com/mssevov18/WpfAppWithEntryLevel";

		public string Solution => String.Empty;

		public ArgumentCode[] Arguments => null;

		public string RunSolution(params object[] args)
		{
			return String.Empty;
		}
	}
}
