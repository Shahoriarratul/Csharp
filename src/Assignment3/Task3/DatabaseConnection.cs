using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DatabaseConnection
    {
        private readonly string Connection;


        public DatabaseConnection(string connectionString)
        {
            Connection = connectionString; ;

            Console.WriteLine("connected" + Connection) ;
        }
    }
}
