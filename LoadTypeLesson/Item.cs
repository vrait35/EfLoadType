using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypeLesson
{
    public class Item:Entity
    {
        public string Name { get; set; }
        public int price { get; set; }
        public  ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}
