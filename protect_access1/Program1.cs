using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect_access1
{
    public class ABC
    {
        protected void sample()
        {
            Console.WriteLine("This the protected class");
        }
    }
 
    class Program1 :ABC                                              
    {

        static void Main(string[] args)
        {
            Program1 p = new Program1();                                        
            p.sample();                                            //protected members are accessed in derived class

            Console.ReadLine();
        }
    }
}
