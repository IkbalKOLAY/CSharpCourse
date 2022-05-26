using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();

            List<string> result = utilities.BuildList<string>("ankara", "izmir", "adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "ikbal" }, new Customer { FirstName = "samet" }, new Customer());
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }
    class Utilities
    {
        // hangi tiple çalışılacaksa o tipte bir sey döndür
        public List<T> BuildList<T>(params T[] items) // ne kadar eleman olacağını bilmediğimiz için params dedik
        {
            return new List<T>(items);
        }
    }
    class Product : IEntity // veritabanı nesnesi
    {
    }
    interface IProductDal : IRepositery<Product>
    {

    }
    class Customer : IEntity // veritabanı nesnesi
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal : IRepositery<Customer>
    {

    }
    class Student : IEntity // veritabanı nesnesi
    {

    }

    interface IEntity
    {

    }

    /* 
        hemen hemen bütün interface ' lerin içerisi aynı oluyor sadece Customerve Product 
        kısımlarını değiştiriyoruz bunun için generics kullanırız
    */

    //interface IRepositery<T> where T : struct //Değer tipleri koymak isteseydik örneğin int kabul edilirdi
    interface IRepositery<T> where T : class, IEntity, new() //T=Referans type olmalı, IEntity'den iplement edilmeli ve new'lenmeli 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
