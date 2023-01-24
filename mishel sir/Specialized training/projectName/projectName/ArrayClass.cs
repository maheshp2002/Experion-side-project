using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectName
{
    internal class ArrayClass
    {
        public string Name { get; set; }
        public const string ConstName = @"This is a constant.
        You got that";

        public ArrayClass(string name) {
            Name = name;
            Console.WriteLine("Constructor worked");
        }
    }
}
