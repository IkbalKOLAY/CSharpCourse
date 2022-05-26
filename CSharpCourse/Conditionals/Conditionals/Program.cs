using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;

            //if (number == 10)
            //{
            //    Console.WriteLine("number is 10");

            //}
            //else
            //{
            //    Console.WriteLine("number is not 10");
            //}

            //Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");
            //Console.ReadLine();

            //if ()
            //{

            //}
            //else if ()
            //{

            //}
            //else
            //{

            //}

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;

            }
            Console.ReadLine();
        }

    }
}
