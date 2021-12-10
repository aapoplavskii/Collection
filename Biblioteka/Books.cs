using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Books
    {
        ConcurrentDictionary<string, int> arraybooks = new ConcurrentDictionary<string, int>();

        internal void Add(string name)
        {

            if (!arraybooks.TryAdd(name, 0))
            {
                Console.WriteLine("Данная книга уже есть в коллекции");
            }

           

        }

        internal void UpdatePercentRead()
        {
            while (true)
            {
                foreach (var book in arraybooks)
                {
                    if (!arraybooks.TryUpdate(book.Key, book.Value + 1, book.Value))
                    {
                        Console.WriteLine($"Ошибка обновления элемента - {book.Key}!");
                        break;

                    }
                    Thread.Sleep(1000);
                    if (book.Value == 100)
                        RemoveBook(book.Key);

                }
            }
            
        }

        internal void WriteBook()
        {

            foreach (var book in arraybooks)
            {
                Console.WriteLine($"{book.Key} - {book.Value}%");

            }

        }

        internal void RemoveBook(string name)
        {
            if (!arraybooks.TryRemove(name, out int value))
            {
                Console.WriteLine($"Не удалось удалить элемент - {name}");
            
            }
        }
    }


    
}
