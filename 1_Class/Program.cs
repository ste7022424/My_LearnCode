using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var S1 = new School_Member("小張",10,2);
            Console.WriteLine(S1.AboutYourSelf());
        }
    }
}
