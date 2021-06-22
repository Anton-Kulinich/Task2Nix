using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Nix
{
    [Table(Name = "SpinReel")]
    public class SpinReel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int Price { get; set; }
        [Column]
        public string Manufacturer { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public string ProductName { get; set; }
        [Column]
        public string CategoryName { get; set; }
        [Column]
        public int BallBearings { get; set; }
        [Column]
        public int Size { get; set; }
        [Column]
        public string LineCapacity { get; set; }
        [Column]
        public int Weight { get; set; }

        public SpinReel(string name, string category, string manufacturer, int price, string description, int bb, int size, string linecapacity, int weight)
        {
            ProductName = name;
            CategoryName = category;
            Manufacturer = manufacturer;
            Price = price;
            Description = description;
            BallBearings = bb;
            Size = size;
            LineCapacity = linecapacity;
            Weight = weight;
        }
        public SpinReel()
        {

        }
    }
}
