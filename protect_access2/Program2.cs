using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using protect_access1;

namespace protect_access2
{
    class Program2:ABC                            //protect members of class ABC can be accessed on derived class of outside the assebly
    {
        static void Main(string[] args)
        {
            Program2 p1 = new Program2();              
            p1.sample();
        }
    }
}
