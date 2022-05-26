using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add() // ezebiliriz demek istiyorsan virtual yazmalısın
            {
                Console.WriteLine("added by default");
            }

            public  void Delete()
            {
                Console.WriteLine("deleted by default");
            }
        }

        class SqlServer:Database
        {
            public override void Add() // sqlserver tarafından add() ezildi
            {
                
                Console.WriteLine("added by sql code");
                // base.Add();
            }
        }

        class MySqlServer:Database
        {

        }
    }
}
