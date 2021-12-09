using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Shop
    {
        int currentcount = 0;

        public ObservableCollection<Item> _price = new ObservableCollection<Item>();
        
        public void Add(string name)
        {

            var newitemprice = new Item(currentcount++, name);

            _price.Add(newitemprice);

        }


        public void Remove(int index)
        {
            var item = _price.FirstOrDefault(x => x.id == index);

            if (item != null)
                _price.Remove(item);
            else
                Console.WriteLine("По такому индексу нет товара!");

        }


    }
}
