using System;
using System.Collections.Immutable;

namespace ImmutableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var part1 = new Part1("Вот дом,\nКоторый построил Джек.");
            var part2 = new Part1("А это пшеница,\nКоторая в темном чулане хранится\nВ доме,\nКоторый построил Джек.");

            part1.AddPart(ImmutableList.Create<string>());
            part2.AddPart(part1.Poem);

            Console.WriteLine("Первый абзац:");
            Console.WriteLine("");
            foreach (var part in part1.Poem)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine("");

            Console.WriteLine("Первый - второй абзац:");
            Console.WriteLine("");
            foreach (var part in part2.Poem)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine("");




        }
    }
}
