using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace Task2Nix
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-RPNK5SQ\SQLEXPRESS;Initial Catalog=task2db;Integrated Security=True";
            DataContext dataContext = new DataContext(connectionString);

            try
            {
                Table<User> users = dataContext.GetTable<User>();
                var query = from u in users where u.Age > 20 orderby u.Name select u;
                GetAllData(users);
                Console.WriteLine(new string('*',20));
                foreach(var u in query)
                {
                    Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error");
            }

            
        }

        static void GetAllData(Table<User> users)
        {
            foreach(var u in users)
            {
                Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
            }
        }
    }
}
