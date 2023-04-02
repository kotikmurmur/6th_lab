// namespace laba_6
// {
//     class Program{
//         public static void Main(string[] args){
//             //Task1_1();
//             //Task1_4();
//            // Task2_1();
//            Task2_2();
//         }
//     struct Sportsmen{
//             public string surname;
//             public double rez;
//     }
//     struct Student{
//         public string surname;
//         public double sred;
//     }
//     static void Task1_1(){
//         Sportsmen[] sp = new Sportsmen[5];
//         string[] s = new string[] {
//         "Иванов", "Петров", "Сидоров",
//         "Кузнецов", "Макаров"};
//         double[] r1 = new double[] {3,
//         1.55, 1.47, 1.46, 1.54};
//         double[] r2 = new double[] {0.1,
//         1.52, 1.48, 1.99, 2};
//         for (int i = 0; i < sp.Length; i++)
//             {
//                 sp[i].surname = s[i];
//                 sp[i].rez = r1[i]+r2[i];
//                // Console.WriteLine("Фамилия "+sp[i].surname+" Результат "+Math.Round(sp[i].rez,2));
//             }
//         for (int i = 0; i < sp.Length - 1; i++)
//             {
//                 double amax = sp[i].rez;
//                 int imax = i;
//                 for (int j = i + 1; j < sp.Length; j++)
//                 {
//                     if (sp[j].rez > amax)
//                         {
//                             amax = sp[j].rez;
//                             imax = j;
//                         }
//                 }
//                 Sportsmen temp;
//                 temp = sp[imax];
//                 sp[imax] = sp[i];
//                 sp[i] = temp;
//             }
//             Console.WriteLine();
//             for (int i = 0; i < sp.Length; i++)
//             {
//                 Console.WriteLine("Фамилия: "+sp[i].surname+" Результат: "+Math.Round(sp[i].rez,2));
//             }
//         }
//          static void Task1_4(){
//         Sportsmen[] sp = new Sportsmen[5];
//         string[] s = new string[] {
//         "Иванов", "Петров", "Сидоров",
//         "Кузнецов", "Макаров"};
//         double[] r1 = new double[] {3,
//         1.55, 1.47, 1.46, 1.54};
//         double[] r2 = new double[] {0.1,
//         1.52, 1.48, 1.99, 2};
//         for (int i = 0; i < sp.Length; i++)
//             {
//                 sp[i].surname = s[i];
//                 if(r1[i]>r2[i]){
//                     sp[i].rez = r1[i];    
//                 }
//                 else{
//                     sp[i].rez=r2[i];
//                 }
                
//                // Console.WriteLine("Фамилия "+sp[i].surname+" Результат "+Math.Round(sp[i].rez,2));
//             }
//         for (int i = 0; i < sp.Length - 1; i++)
//             {
//                 double amax = sp[i].rez;
//                 int imax = i;
//                 for (int j = i + 1; j < sp.Length; j++)
//                 {
//                     if (sp[j].rez > amax)
//                         {
//                             amax = sp[j].rez;
//                             imax = j;
//                         }
//                 }
//                 Sportsmen temp;
//                 temp = sp[imax];
//                 sp[imax] = sp[i];
//                 sp[i] = temp;
//             }
//             Console.WriteLine();
//             for (int i = 0; i < sp.Length; i++)
//             {
//                 Console.WriteLine("Фамилия: "+sp[i].surname+" Результат: "+Math.Round(sp[i].rez,2));
//             }
//         }
//          static void Task2_1(){
//         Student[] st = new Student[5];
//         string[] s = new string[] {
//         "Иванов", "Петров", "Сидоров",
//         "Кузнецов", "Макаров"};
//         double[] ex1 = new double[] {2,4,5,3,2};
//         double[] ex2 = new double[] {3,5,4,2,2};
//         double[] ex3 = new double[] {2,2,5,2,2};
//         double[] ex4 = new double[] {5,5,4,5,3};
//         //фамилии
//         for (int i = 0; i < st.Length; i++)
//             {
//                 st[i].surname = s[i];
//                 st[i].sred= (ex1[i]+ex2[i]+ex3[i]+ex4[i])/4;
//                // Console.WriteLine("Фамилия "+sp[i].surname+" Результат "+Math.Round(sp[i].rez,2));
//             }
//         for (int i = 0; i < st.Length - 1; i++)
//             {
//                 double amax = st[i].sred;
//                 int imax = i;
//                 for (int j = i + 1; j < st.Length; j++)
//                 {
//                     if (st[j].sred > amax)
//                         {
//                             amax = st[j].sred;
//                             imax = j;
//                         }
//                 }
//                 Student temp;
//                 temp = st[imax];
//                 st[imax] = st[i];
//                 st[i] = temp;
//             }
//             Console.WriteLine();

//             for (int i = 0; i < st.Length; i++)
//             {
//                  if(st[i].sred>=4){
//                      Console.WriteLine("Фамилия: "+st[i].surname+" Результат: "+Math.Round(st[i].sred,2));
//                  }
//             }
//         }
//         static void Task2_2(){
//         Student[] st = new Student[5];
//         string[] s = new string[] {
//         "Иванов", "Петров", "Сидоров",
//         "Кузнецов", "Макаров"};
//         double[] mth = new double[] {3,2,4,5,3};
//         double[] ph = new double[] {3,4,5,4,3};
//         double[] ru = new double[] {2,3,4,5,4};
//         for (int i = 0; i < st.Length; i++)
//             {
//                 if(mth[i]>2&&ph[i]>2&&ru[i]>2){
//                 st[i].surname = s[i];
//                 st[i].sred = (mth[i]+ph[i]+ru[i])/3;
//                 }
//                // Console.WriteLine("Фамилия "+sp[i].surname+" Результат "+Math.Round(sp[i].rez,2));
//             }
//         for (int i = 0; i < st.Length - 1; i++)
//             {
//                 double amax = st[i].sred;
//                 int imax = i;
//                 for (int j = i + 1; j < st.Length; j++)
//                 {
//                     if (st[j].sred > amax)
//                         {
//                             amax = st[j].sred;
//                             imax = j;
//                         }
//                 }
//                 Student temp;
//                 temp = st[imax];
//                 st[imax] = st[i];
//                 st[i] = temp;
//             }
//             Console.WriteLine();
//             for (int i = 0; i < st.Length; i++)
//             {
//                 if(st[i].sred!=0){
//                     Console.WriteLine("Фамилия: "+st[i].surname+" Результат: "+Math.Round(st[i].sred,2));
//                 }
//             }
//         }
//     }
// }
using System;
using System.Linq;

namespace PrepDepartment
{
    struct Student
    {
        public string Name;
        public int MathGrade;
        public int PhysicsGrade;
        public int RussianGrade;

        public Student(string name, int math, int physics, int russian)
        {
            Name = name;
            MathGrade = math;
            PhysicsGrade = physics;
            RussianGrade = russian;
        }

        public double GetAverageGrade()
        {
            int sum = MathGrade + PhysicsGrade + RussianGrade;
            return (double)sum / 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Иванов", 4, 5, 3),
                new Student("Петров", 5, 4, 5),
                new Student("Сидоров", 3, 3, 4),
                new Student("Панов", 5, 5, 5),
                new Student("Соколов", 4, 4, 4),
                new Student("Кузнец", 5, 4, 5),
                new Student("Новиков", 4, 4, 5),
                new Student("Федоров", 5, 5, 5),
                new Student("Морозов", 3, 3, 3),
                new Student("Найт", 5, 5, 4),
                new Student("Попов", 2, 2, 3),
                new Student("Андреев", 4, 5, 4)
            };

            var successfulStudents = students
                .Where(s => s.MathGrade != 2 && s.PhysicsGrade != 2 && s.RussianGrade != 2)
                .OrderByDescending(s => s.GetAverageGrade())
                .ToArray();

            Console.WriteLine("Успешные студенты, отсортированныe по убыванию среднего балла:");
            Console.WriteLine("Имя\t\tМатематика\tФизика\t\tРусский язык\tСредний балл");

            foreach (var student in successfulStudents)
            {
                Console.WriteLine($"{student.Name}\t\t{student.MathGrade}\t\t{student.PhysicsGrade}\t\t{student.RussianGrade}\t\t{Math.Round(student.GetAverageGrade(), 2)}");
            }

            Console.ReadKey();
        }
    }
}
