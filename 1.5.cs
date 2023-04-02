using System;
using System.Linq;

// 1.5
namespace App {
    public struct Student {
        public string Surname;
        public int Mark;
        public int SkippedLessons;
        
        public Student(string surname, int mark, int skippedLessons){
            Surname = surname;
            Mark = mark;
            SkippedLessons = skippedLessons;
        }
    }
    
    public class Program { 
        public static void Main() {
           Student[] students = new[] {
               new Student("Петров", 0, 10),
               new Student("Иванов", 3, 4),
               new Student("Сидоров", 2, 6),
               new Student("Макаров", 5, 9),
               new Student("Коргин", 0, 4),
               new Student("Сёмин", 2, 3),
               new Student("Зайцев", 5, 0),
           };
            
            Student[] sortedStudents = students
                .Where(x => x.Mark == 2)
                .OrderByDescending(x => x.SkippedLessons)
                .ToArray();
            
            foreach (Student student in sortedStudents) {
                 Console.WriteLine("Фамилия: {0} \t Кол-во пропущенных занятий: {1}", 
                                   student.Surname,
                                   student.SkippedLessons);       
            }
        }
    }
}
