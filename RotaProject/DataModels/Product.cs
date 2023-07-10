using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaProject.DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float StockBalance { get; set; }
        public Category Category { get; set; }
    }
}
