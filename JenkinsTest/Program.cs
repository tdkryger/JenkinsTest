using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            JenkinsTest.CL.Class1 c = new CL.Class1();
            Console.WriteLine(string.Format("4 + 5 = {0}", c.Add(4, 5)));
            Console.ReadLine();
        }
    }
}
