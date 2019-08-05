using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(2010, 05, 12, 13, 15, 00);
            DateTime b = new DateTime(2010, 05, 12, 13, 45, 00);
            Console.WriteLine(b.Subtract(a).TotalMinutes);
        }
    }
}
