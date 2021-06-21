using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Nix
{
    public interface IReel
    {
         int BallBearings { get; set; }
         int Size { get; set; }
         string LineCapacity { get; set; }
         int Weight { get; set; }
    }
}
