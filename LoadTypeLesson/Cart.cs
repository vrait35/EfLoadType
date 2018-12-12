using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTypeLesson
{
    public class Cart:Entity
    {      
        public string OWnerFullName { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
