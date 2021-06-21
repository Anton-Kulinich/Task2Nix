using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2Nix
{
    [Table]
    [InheritanceMapping(Code = "G", Type = typeof(CarpReel))]
    [InheritanceMapping(Code = "S", Type = typeof(FeederReel))]
    [InheritanceMapping(Code = "R", Type = typeof(SpinReel))]
    public class FishingProduct
    {
        [Column]
        public int Price { get; set; }
        [Column]
        public string Manufacturer { get;  set; }
        [Column]
        public string Description { get;  set; }
        [Column]
        public string ProductName { get;  set; }
        [Column]
        public string CategoryName { get;  set; }

        public virtual void ProductInfo()
        {
            //Console.WriteLine(new string('-', 20));
            Console.WriteLine($"{CategoryName}" +
                $"\nProduct Name: {ProductName}" +
                $"\nManufactured: {Manufacturer}" +
                $"\nDecription: {Description}" +
                $"\nPrice: {Price}$");
        }

        public virtual void ShortDesc()
        {
            Console.Write($"{CategoryName} | {ProductName} | {Manufacturer} | {Price}$ | ");
        }

        public FishingProduct(string name, string category, string manufacturer, int price, string description)
        {
            ProductName = name;
            CategoryName = category;
            Manufacturer = manufacturer;
            Price = price;
            Description = description;
        }
        public FishingProduct()
        {

        }
    }
}
