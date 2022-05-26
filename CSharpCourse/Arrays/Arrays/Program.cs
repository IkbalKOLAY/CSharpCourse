using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "ikbal";
            string student2 = "samet";

            string[] students = new string[3];
            students[0] = "ikbal";
            students[1] = "samet";

            //string[] students2 = new[]{"ikbal","samet"};
            //string[] students2 = { "ikbal", "samet" };

            foreach (var student in students)
            {
                Console.WriteLine(student);

            }

            string[,] regions = new string[7, 3]
            {
                {"*","*",""},
                {"","",""},
                {"","",""},
                {"","",""},
                {"","*",""},
                {"","*",""},
                {"","*","*"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

            }
            

            Console.ReadLine();
        }
    }
}
