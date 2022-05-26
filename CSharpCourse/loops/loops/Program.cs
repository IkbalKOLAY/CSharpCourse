using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%10==0)
            //    {
            //        Console.WriteLine(i);

            //    }

            //}

            //Console.WriteLine("************************");

            //int number = 10;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}


            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number>=0);

            string[] names = new[] { "ikbal", "samet", "hatice" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
