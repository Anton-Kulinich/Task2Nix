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
            
            
                Table<CarpReel> carpReels = dataContext.GetTable<CarpReel>();
                Table<FeederReel> feederReels = dataContext.GetTable<FeederReel>();
                Table<SpinReel> spinReels = dataContext.GetTable<SpinReel>();
                var query = from r in carpReels where r.Price < 2000 orderby r.Price select r;
                foreach(var item in query)
                {
                    Console.WriteLine($"{item.Manufacturer} {item.Manufacturer} {item.Price}");
                }
            
            
        }


        
    }
}
