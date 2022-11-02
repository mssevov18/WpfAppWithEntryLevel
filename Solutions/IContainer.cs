using System;
using System.Security.Cryptography;

namespace Solutions
{
    public interface IContainer
    {
        public string Title { get; }
        public string Statement { get; }
        public string Link { get; }
        public string Solution { get; }

        public string RunSolution();
    }
}
