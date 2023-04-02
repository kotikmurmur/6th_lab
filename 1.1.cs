using System;
using System.Collections.Generic;

namespace JumpCompetition
{
    class Participant
    {
        public string LastName;
        public string Society;
        public double FirstJump;
        public double SecondJump;

        public Participant(string lastName, string society, double firstJump, double secondJump)
        {
            LastName = lastName;
            Society = society;
            FirstJump = firstJump;
            SecondJump = secondJump;
        }

        public double GetTotalScore()
        {
            return FirstJump + SecondJump;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participants = new List<Participant>()
            {
                new Participant("Ivanov", "Spartak", 7.8, 8.1),
                new Participant("Petrov", "Dynamo", 7.5, 8.0),
                new Participant("Sidorov", "Zenit", 7.6, 7.8),
                new Participant("Smirnov", "Spartak", 8.2, 7.5),
                new Participant("Kuznetsov", "Dynamo", 7.9, 7.7)
            };

            participants.Sort((p1, p2) => p2.GetTotalScore().CompareTo(p1.GetTotalScore())); // сортировка по убыванию суммы баллов

            Console.WriteLine("Протокол соревнований:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", "Место", "Фамилия", "Общество", "1-я попытка", "2-я попытка");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < participants.Count; i++)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10}", i+1, participants[i].LastName, participants[i].Society, participants[i].FirstJump, participants[i].SecondJump);
            }
        }
    }
}
/*
using System;
using System.Linq;

// 1.1
namespace App {
    public struct Sportsman {
        public string Surname;
        public string Patronymic;
        public double SumMark;
        
        public Sportsman(
            string surname,
            string patronymic,
            double mark1,
            double mark2) {
            Surname = surname;
            Patronymic = patronymic;
            SumMark = mark1 + mark2;
        }
    }
    
    public class Program { 
        public static void Main() {
            Sportsman[] sportsmans = new Sportsman[3] {
                new Sportsman("Иванов", "Иванович", 1.60, 2.00),
                new Sportsman("Петров", "Петрович", 2.10, 3.00),
                new Sportsman("Сидоров", "Сидорович", 1.00, 1.30)
            };
            
            Sportsman[] sortedSportsmans = sportsmans.OrderByDescending(x => x.SumMark).ToArray();
            
            foreach (Sportsman sportsman in sortedSportsmans) {
                 Console.WriteLine("Фамилия: {0} \t Отчество: {1} \t Сумма попыток: {2:f}", 
                                   sportsman.Surname,
                                   sportsman.Patronymic,
                                   sportsman.SumMark);       
            }
        }
    }
}
*/
