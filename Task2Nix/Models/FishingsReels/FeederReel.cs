using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Nix
{
    [Table(Name = "FeederReel")]
    public class FeederReel : FishingProduct, IReel
    {
        [Column]
        public int BallBearings { get; set; }
        [Column]
        public int Size { get; set; }
        [Column]
        public string LineCapacity { get; set; }
        [Column]
        public int Weight { get; set; }

        public FeederReel(string name, string category, string manufacturer, int price, string description, int bb, int size, string linecapacity,int weight) : base(name, category, manufacturer, price, description)
        {
            BallBearings = bb;
            Size = size;
            LineCapacity = linecapacity;
            Weight = weight;
        }

        public override void ProductInfo()
        {
            base.ProductInfo();
            Console.WriteLine($"Ball bearings: {BallBearings}\n" +
                $"Size: {Size}\n" +
                $"Line capacity: {LineCapacity} mm/m\n" +
                $"Weight: {Weight}g");
        }

        public override void ShortDesc()
        {
            base.ShortDesc();
            Console.WriteLine($"Size : {Size}");
        }

    }
}
