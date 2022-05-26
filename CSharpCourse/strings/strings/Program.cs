using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "my name is ikbal kolay";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is oğuz kolay";
            

            bool result3 = sentence.EndsWith("y");
            bool result4 = sentence.StartsWith("m");
            var result5 = sentence.IndexOf("name");     // bulunmazdığında -1 döndürür
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");    //aramaya sondan başlar
            var result8 = sentence.Insert(0, "hello ");     //metnin basına-0- hello ekler
            var result9 = sentence.Substring(3);    // 3.karakterden itibaren parçala
            var result10 = sentence.Substring(3, 4);    // 3.karakterden itibaren 4 taneyi al
            var result11 = sentence.ToLower();  //bütün karakterleri küçüğe çevirir
            var result12 = sentence.ToUpper();  //bütün karakterleri büyüğe çevirir
            var result13 = sentence.Replace(" ", "-");
            var result14 = sentence.Remove(2);

            Console.WriteLine(result14);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }


            string city2 = " istanbul";
            //string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));



            Console.ReadLine();
        }
    }
}
