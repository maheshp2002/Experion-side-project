using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectName
{
    internal class Person
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Total()
        {
            return Mark1 + Mark2;
        }
    }
}
