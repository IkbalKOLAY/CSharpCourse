using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    private   - değişkenler sadece tanımlandığı blokta geçerlidir.
    protected - private'ın bütün özelliklerini karşılar tek farkı inherit edildiğinde de kullanılabilir
    internal  - o proje içerisinde istediğimiz noktada onu çağırabiliyoruz
    public    - classları farklı projelerde de kullanmak istiyorsak

    private -> protected -> internal -> public

*/

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; }

        public void Save()
        {
            
        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }

    internal class Course  // class ' ın default ı internal dır
    {
        public string Name { get; set; }
    }
}
