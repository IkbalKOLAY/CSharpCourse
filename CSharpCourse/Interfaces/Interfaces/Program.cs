using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro(); 

            /* 
               - Interfaces'ler new lenemez
                    x Iperson person = new IPerson(); x
               - Ama bunu yerine ->
                     person = new Customer();
                    Iperson person = new Student();
                    Iperson person = new Worker();
                 newlwnwbilir
            */

            //Demo();

            // elimizdeki datayı tüm veri tabanlarına atmak istiyoruz
            // öncelikle bi array tanımlıyoruz

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager manager = new CustomerManager();
            manager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ikbal",
                LastName = "kolay",
                Address = "Trabzon"

            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "samet",
                LastName = "ramazan",
                Depertmant = "enginner"

            };


            manager.Add(student);
            manager.Add(customer);
        }
    }

    interface IPerson  // interfaces de tanımladığımız özellikleri Customer ve Student de tanmlamamız lazım
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; } // class a ait özellik ekleyebiliyoruz
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Depertmant { get; set; } // class a ait özellik ekleyebiliyoruz

    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Depertmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
