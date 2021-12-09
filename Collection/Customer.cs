using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Customer
    {
        public string _name { get; private set; }
        private Shop _shop;

        public Customer(string name, Shop shop)
        {
            _name = name;
            _shop = shop;
            _shop._price.CollectionChanged += _OnItemChanged;
        }

        private void _OnItemChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {

                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен новый товар: {e.NewItems[0]}");
                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален товар: {e.OldItems[0]}");
                    break;

            }
        }
    }
}
