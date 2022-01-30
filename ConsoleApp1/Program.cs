using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number : ");
            string str = Console.ReadLine();
            int first = Convert.ToInt32(str);
            Console.WriteLine("Input second number : ");
            str = Console.ReadLine();
            int second = Convert.ToInt32(str);
            int res = first + second;
            Console.WriteLine("Summ = " + res);
                
        }
    }
}
