namespace Uni{
    struct Session {
        public string Surname; public int[] Marks;
        public Session (string surname, int[]marks) {
            Surname = surname; Marks = marks;
        }
        public double AvgForStudent(){
             double sum = 0;
            for (int i = 0; i < Marks.Length; i++) {
            sum += Marks[i]; 
            }
        return sum/Marks.Length; 
        }
    }
     struct Student1{
         public string Group;
         public Session[] Sessions; private double AvgValue;
        public Student1(string group, params Session[]sessions) {
            Group = group; Sessions = sessions;
            AvgValue = 0; 
        }
        public double Avg()
        {
            if (AvgValue == 0) {
                double s = 0; 
                foreach (Session session in Sessions){
                    foreach (int mark in session.Marks){
                        s += mark;
                        }
                }
                AvgValue= s / Sessions.Length;
            }
            return AvgValue;
        }
    }
    class Program{
        static void Main() {
            Student1[] students = new Student1[3];
            students[0] = new Student1("Зайчики",
            new Session("Иванов", new int[] {5,5,4,5,4}),
            new Session("Быстров", new int[] { 5, 5, 2, 5, 4 }),
            new Session("Зайцев", new int[] { 4, 5, 4, 5, 4 }), 
            new Session("Кабанов", new int[] { 4, 5, 4, 5, 4 }) );
            students[1] = new Student1("Котики",
            new Session("Сидоров", new int[] { 4, 5, 4, 5, 4 }),
            new Session("Котов", new int[] { 4, 5, 4, 5, 4 }),
            new Session("Быстров", new int[] { 3, 5, 4, 5, 4 }), 
            new Session("Кротов", new int[] { 4, 5, 4, 5, 4 }) );
            students[2] = new Student1("Остальные",
            new Session("Злобин", new int[] { 4, 5, 5, 5, 5 }),
            new Session("Незлобин", new int[] { 5, 5, 4, 5, 4 }),
            new Session("Бодров", new int[] { 3, 5, 4, 5, 4 }),
            new Session("Гомель", new int[] { 4, 5, 4, 5, 4 }) );
            foreach(Student1 student in students) {
                Console.WriteLine($"{student.Group}");
                foreach (Session session in student.Sessions.OrderByDescending(a => a.AvgForStudent())){
                    Console.WriteLine($"{session.Surname,-10}| {session.AvgForStudent()}");
                }
            }
            double Avg = 0;

            foreach (Student1 student in students) {
                foreach (Session session in student.Sessions) {
                    Avg += session.AvgForStudent(); 
                }
                students = students.OrderByDescending(a => Avg).ToArray(); 
            }
            // students = students.OrderByDescending(a => a.Avg()).ToArray(); Console.WriteLine("Список групп в порядке убывания среднего балла");
            Console.WriteLine(); 
            foreach (Student1 student in students){
                Console.WriteLine($"{student.Group,-20}| {student.Avg()}");
            }
        }
    }
}
