using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Nix
{
    [Table(Name = "Users")]
    class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public int Age { get; set; }
    }
}
