using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public static object Teacher { get; private set; }

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(5);
            //customerManager.List();

            Product product = new Product { Name = "mouse" };
            Product product1 = new Product();

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("product");
            personManager.Add();

            Teacher.Number = 10;
             

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 1; // default olarak 1 verdik eğer customermanageri newlerken değer verilmezse 1 olarak çalıştır
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager() // override yaptık default çalışması için
        {
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added ");
        }

        
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id)
        {
            _id = id;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();

    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }


    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }

        static class Teacher  // new lenemez
        {
            public static int Number { get; set; }; // prop tanımlarken static olmak zorunda
        }

        static class Utilities
        {
            public static void Validate()
            {
                Console.WriteLine("validation is done");
            }
        }
    }




















}
