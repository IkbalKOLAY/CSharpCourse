using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
         
            var result = Add2(2);
            //Console.WriteLine(result);
            Console.WriteLine(Add3(3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2=8)
        {
            return number1 + number2;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }

    // ref değeri baştan vermek istiyorsak , out değer vermeye gerek yoksa
}
