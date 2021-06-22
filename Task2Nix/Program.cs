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
            /*
                var query = from r in carpReels where r.Price < 3000 orderby r.Price select r;
                foreach(var item in query)
                {
                    Console.WriteLine($"{item.Manufacturer} {item.ProductName} {item.Price.ToString("C2")}");
                }
                */

            /*
            GetAllCarpReelSortByPrice(dataContext);
            Console.WriteLine(new string('*', 20));

            CarpReel carpReel = new CarpReel("Blackpool", "Reel", "Carp pro", 3500, "Reel for carp fishing", 12, 10000, "0.3/300, 0.4/250", 350);

            InsertNewCarpReel(dataContext, carpReel);
            Console.WriteLine(new string('*',20));

            GetAllCarpReelSortByPrice(dataContext);
            */

            DeleteCarpReelById(dataContext, 5);
        }

        static void InsertNewCarpReel(DataContext context, CarpReel carpReel)
        {
            try
            {
                context.GetTable<CarpReel>().InsertOnSubmit(carpReel);
                context.SubmitChanges();
                Console.WriteLine("Success");
            }
            catch
            {
                throw new Exception();
            }
        }

        static void InsertNewFeederReel(DataContext context, FeederReel feederReel)
        {
            try
            {
                context.GetTable<FeederReel>().InsertOnSubmit(feederReel);
                context.SubmitChanges();
                Console.WriteLine("Success");
            }
            catch
            {
                throw new Exception();
            }
        }

        static void InsertNewSpibReel(DataContext context, SpinReel spinReel)
        {
            try
            {
                context.GetTable<SpinReel>().InsertOnSubmit(spinReel);
                context.SubmitChanges();
                Console.WriteLine("Success");
            }
            catch
            {
                throw new Exception();
            }
        }

        static void GetAllCarpReelSortByPrice(DataContext context)
        {
            var table = context.GetTable<CarpReel>();
            var query = from r in table orderby r.Price select r;
            foreach(var item in query)
            {
                Console.WriteLine($"{item.Manufacturer} | {item.ProductName} | {item.Price.ToString("C2")}");
            }
        }

        static void GetAllFeederReelSortBySize(DataContext context)
        {
            var table = context.GetTable<FeederReel>();
            var query = from r in table orderby r.Size select r;
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Manufacturer} | {item.ProductName} | {item.Price.ToString("C2")}");
            }
        }

        static void GetAllSpinReelSortBySize(DataContext context)
        {
            var table = context.GetTable<SpinReel>();
            var query = from r in table orderby r.Size select r;
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Manufacturer} | {item.ProductName} | {item.Price.ToString("C2")}");
            }
        }

        static void EditProductNameFeederReel(DataContext context, int id)
        {
            FeederReel feederReel = (from r in context.GetTable<FeederReel>() where r.Id == id select r).FirstOrDefault();
            try
            {
                Console.WriteLine("Enter new product name:");
                string newpname = Console.ReadLine();
                feederReel.ProductName = newpname;
                context.SubmitChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        static void DeleteCarpReelById(DataContext context, int id)
        {
            CarpReel carpReel = (from r in context.GetTable<CarpReel>() where r.Id == id select r).FirstOrDefault();
            try
            {
                context.GetTable<CarpReel>().DeleteOnSubmit(carpReel);
                context.SubmitChanges();
                Console.WriteLine("Successfully deleted");
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
