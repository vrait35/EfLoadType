using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LoadTypeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new ShopContext())
            {
                //   var items = context.Items.Include(item => item.Carts).ToList();  zhadni
                Guid id = Guid.Parse("asdasddgdfgdf");
                var result = context.Items.FirstOrDefault(i => i.Id == id);
                context.Entry(result).Collection<Cart>("Carts").Load();
              /*
             существует 2 вида загрузки:
             1.ленивая(lazy loaading)-virtual
             2.жадная(eager loading)-include
             3.явная(expicit loading)-entry(t)
             */
            }
        }
    }
}
