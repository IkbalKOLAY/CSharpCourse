using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictonary = new Dictionary<string, string>();
            dictonary.Add("book", "kitap");
            dictonary.Add("table", "tablo");
            dictonary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictonary["table"]);

            foreach (var item in dictonary)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }
            // sorgulama
            Console.WriteLine(dictonary.ContainsKey("glass"));
            Console.WriteLine(dictonary.ContainsKey("table"));

           
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); // sadece string değerleri kabul eder
            cities.Add("ankara");
            cities.Add("istanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //cities listesinde arama yapar,true - false döndürür
            Console.WriteLine(cities.Contains("ankara"));

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "ikbal" });
            //customers.Add(new Customer { Id = 2, FirstName = "samet" });


            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "ikbal" },
                new Customer { Id = 2, FirstName = "samet" }
            };


            var _customer = new Customer
            {
                Id = 3,
                FirstName = "hatice"
            };

            customers.Add(_customer);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="kader" },
                new Customer{Id=5,FirstName="fatma" }
            });

            //customers.Clear(); // listeyi temizler

            // liste içerisinde arama yapar ama listeyi new lediğimiz için reerans değeri değişir ve false döner
            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "ikbal" }));

            //hata almamak için gerçek referans tutan bir sey göndermeliyiz, true döner
            Console.WriteLine(customers.Contains(_customer));

            //listedeki elemanın kaçıncı sırada olduğunu verir
            var index = customers.IndexOf(_customer);
            Console.WriteLine("first index : {0}", index);

            //listedeki elemanın sondan kaçıncı sırada olduğunu verir
            var index2 = customers.LastIndexOf(_customer);
            Console.WriteLine("last index : {0}", index2);

            // istenilen indexe değer ekleyebiliriz
            customers.Insert(0, _customer);
            var _index = customers.IndexOf(_customer);
            Console.WriteLine("index : {0}", _index);

            // bulduğu ilk değeri siler
            customers.Remove(_customer);
            //müşterilerden adı ikbal olanları bul ve sil
            customers.RemoveAll(c => c.FirstName == "ikbal");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }


            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
        }

        //private static void ArrayList()
        //{
        //    //string[] cities = new string[2] { "ankara", "istanbul" };
        //    //cities = new string[3]; // new'lendiği için yeni referans oluştu
        //    //Console.WriteLine(cities[0]);


        //    // type-safe olmadığında arraylist kullanılabilir

        //    ArrayList cities = new ArrayList(); // derleyici hatası veriyor

        //    cities.Add("ankara");
        //    cities.Add("adana");

        //    cities.Add("istanbul");
        //    cities.Add(1);
        //    cities.Add("a");

        //    foreach (var city in cities)
        //    {
        //        Console.WriteLine(city);
        //    }
        //}
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
