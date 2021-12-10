using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            var newarraybooks = new Books();


            Task.Run (() =>
            {
                newarraybooks.UpdatePercentRead();
            });
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Вывести список непрочитанного");
                Console.WriteLine("3. Выйти из приложения");

                var otvet = Console.ReadKey();
                Console.WriteLine();

                switch (otvet.KeyChar)
                {
                    case '1':

                        AddNewBook(newarraybooks);
                        break;
                    case '2':
                        newarraybooks.WriteBook();
                        break;
                    case '3':
                        break;
                    default:
                        Console.WriteLine("Необходимо ввести цифры меню!");
                        break;

                }

                if (otvet.KeyChar == '3')
                {
                    break;
                }

            }

        }

        
        public static void AddNewBook(Books newarraybooks)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите название книги");

            var newnamebook = Console.ReadLine();

            newarraybooks.Add(newnamebook);

        }   
    }
}
