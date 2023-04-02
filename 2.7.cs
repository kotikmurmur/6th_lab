using System;

namespace ChessTournament
{
    struct Player
    {
        public string Name;
        public double Points;

        public Player(string name, double points)
        {
            Name = name;
            Points = points;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = {
                new Player("Иванов", 5),
                new Player("Петров", 3),
                new Player("Сидоров", 6),
                new Player("Круг", 2.5),
                new Player("Соколов", 4.5),
                new Player("Панов", 6),
                new Player("Новиков", 4),
                new Player("Федоров", 3),
                new Player("Морозов", 5),
                new Player("Зайцев", 2),
                new Player("Попов", 5.5),
                new Player("Андреев", 3.5)
            };


            Array.Sort(players, (p1, p2) => p2.Points.CompareTo(p1.Points));

            Console.WriteLine("Турнирная таблица:");
            Console.WriteLine("Место\tИмя\t\tОчки");
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{players[i].Name}\t\t{players[i].Points}");
            }

            Console.ReadKey();
        }
    }
}
