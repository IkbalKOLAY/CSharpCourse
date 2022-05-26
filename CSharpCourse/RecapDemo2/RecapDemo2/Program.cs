using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();  // database loglama
            //customerManager.Logger = new FileLogger();    // file a loglama
            //customerManager.Logger = new SmsLogger();     // Sms a loglama
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
                        //ILogger[] loggers = new ILogger[2]
                        //{
                        //    new DatabaseLogger(),
                        //    new FileLogger()
                        //};
                        //foreach (var logger in loggers)
                        //{
                        //    logger.Log();
                        //}

            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }


    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }

    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }

}
