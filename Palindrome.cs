using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r, rev = 0, m;
            Console.Write(Console.ReadLine());
            n = int.Parse("enter the values");
            m = n;
            while (n > 0)
            {
                r = n % 10;
                rev = (rev * 10) + r;
                n = n / 10;
            }
            if (rev == 0)

                Console.WriteLine("it is tge pali");
            else

                Console.WriteLine("it not a parlin");
            Console.ReadLine();
        }
    }

}
