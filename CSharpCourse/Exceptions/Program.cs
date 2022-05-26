using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }

            //method
            // action delegasyonu
            HandleException(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);         
            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "ikbal", "samet", "hatice" };

            if (!student.Contains("ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "ikbal", "samet", "hatice" };
                students[3] = "ahmet";

            }
            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                //exception hakkında daha fazla bilgi verir
                //Console.WriteLine(exception.InnerException);
            }
        }
    }
}
