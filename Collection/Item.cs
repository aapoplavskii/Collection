using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Item
    {
        public int id { get; }
        public string name { get; }

        public Item(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return "наименование - " + name + ", идентификатор - " + id;
        }
    }
}
