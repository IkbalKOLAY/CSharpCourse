using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //Console.WriteLine("Hello World!");

            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 = 10.5;
            decimal number6 = 10.35435m;
            var number7 = 10;
            number7 = 'İ';

            Console.WriteLine("Number 1 is  : {0}",number1);
            Console.WriteLine("Number 2 is  : {0}", number2);
            Console.WriteLine("Number 3 is  : {0}", number3);
            Console.WriteLine("Number 4 is  : {0}", number4);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}",(int)character);//ascii karakterini gösterir
            Console.WriteLine("Number 5 is  : {0}", number5);
            Console.WriteLine("Number 6 is  : {0}", number6);
            Console.WriteLine("Number 7 is  : {0}", number7);
            Console.WriteLine((int)Days.cuma);
            Console.ReadLine();
        }
    }
    enum Days
    {
        pazartesi,sali,carsamba,persembe,cuma,cumartesi,pazar
    }
}
