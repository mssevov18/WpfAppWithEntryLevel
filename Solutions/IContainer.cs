using System;

namespace Solutions
{
    public interface IContainer
    {
        public string Title { get; }
        public string Statement { get; }
        public string Link { get; }
        public string Solution { get; }
        public TypeCode[] Arguments { get; }

        public string RunSolution(params object[] args);
    }
}
