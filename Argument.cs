using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, b;
            if (args.Length == 0)
            {
                Console.WriteLine("no argument");
            }
            else
            {
                a = double.Parse(args[0]);
                b = double.Parse(args[1]);
                double sum = 0, sub = 0, mul = 0, div = 0;
                sum = a + b;
                Console.WriteLine("the sum of{0}and{1}is:{2}", a, b, sum);
                sub = a - b;
                Console.WriteLine("the sum of{0}and{1}is:{2}", a, b, sub);
                mul = a * b;
                Console.WriteLine("the sum of{0}and{1}is:{2}", a, b, mul);
                div = a / b;
                Console.WriteLine("the sum of{0}and{1}is:{2}", a, b, div);
                Console.ReadLine();
            }
        }
    }
}
