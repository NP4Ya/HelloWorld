using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(1, 11);
            if (a > 11)
            {
                Console.WriteLine("Hey, Mr.Arghworth!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadKey();
        }
    }
}
