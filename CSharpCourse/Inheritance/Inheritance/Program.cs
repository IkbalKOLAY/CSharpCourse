using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person[] persons = new Person[3] 
            {
                new Customer
                {Id=1,
                    FirstName="ikbal",
                    LastName="kolay",
                    City="Trabzon"
                },
                new Student
                {
                    Id=2,
                    FirstName="samet",
                    LastName="ramazan",
                    Depertmant="engineer"
                },
                new Person()
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
            
            
            Console.ReadLine();

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        
        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Depertmant { get; set; }
        }
    }
}
