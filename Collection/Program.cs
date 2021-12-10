using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            var customer = new Customer("Первый покупатель", shop);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Для ввода нового товара нажмите A.");
                Console.WriteLine("Для удаления товара нажмите D.");
                Console.WriteLine("Для выхода из программы нажмите X.");

                var otvet = Console.ReadKey();
                Console.WriteLine();

                switch (otvet.KeyChar)
                {
                    case 'A':

                        shop.Add();
                        
                        break;
                    case 'D':
                        RemoveItemInShop(shop);
                       
                        break;
                    case 'X':
                        break;
                    default:
                        Console.WriteLine("Необходимо ввести указанные символы!");
                        break;

                }

                if (otvet.KeyChar == 'X')
                {
                    break;
                }

            }


        }

        private static void RemoveItemInShop(Shop shop)
        {
            Console.WriteLine("Введите индекс товара, который необходимо удалить!");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                shop.Remove(index);
            }
            else
            {
                Console.WriteLine("Для удаления товара необхидимо вводить его индекс!");
                RemoveItemInShop(shop);
            }
        }

        
                   
    }
}
