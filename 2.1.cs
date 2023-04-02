using System;
using System.Linq;

namespace App {
    public struct ExamResult {
        public string Surname;
        public int Exam1;
        public int Exam2;
        public int Exam3;
        public int Exam4;
        
        public ExamResult(string surname, int exam1, int exam2, int exam3, int exam4) {
            Surname = surname;
            Exam1 = exam1;
            Exam2 = exam2;
            Exam3 = exam3;
            Exam4 = exam4;
        }
        
        public double GetAverage() {
            return (Exam1 + Exam2 + Exam3 + Exam4) / 4.0;
        }
    }
    
    public class Program {
        public static void Main() {
            ExamResult[] results = new[] {
                new ExamResult("Иванов", 4, 5, 4, 5),
                new ExamResult("Петров", 5, 4, 4, 4),
                new ExamResult("Сидоров", 4, 4, 3, 4),
                new ExamResult("Смирнов", 3, 4, 5, 4),
                new ExamResult("Кузнецов", 4, 4, 4, 4),
                new ExamResult("Соколов", 5, 5, 5, 5),
                new ExamResult("Новиков", 4, 5, 4, 5),
                new ExamResult("Морозов", 3, 3, 3, 3),
                new ExamResult("Волков", 5, 4, 5, 4),
                new ExamResult("Козлов", 4, 4, 4, 4)
            };
            
            var goodStudents = results.Where(x => x.GetAverage() >= 4)
                                       .OrderByDescending(x => x.GetAverage());
            
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10}", 
                              "Фамилия", "Экзамен 1", "Экзамен 2", "Экзамен 3", "Экзамен 4", "Средний балл");
            
            foreach (var student in goodStudents) {
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10:F2}", 
                                  student.Surname, student.Exam1, student.Exam2, student.Exam3, student.Exam4, student.GetAverage());
            }
        }
    }
}
