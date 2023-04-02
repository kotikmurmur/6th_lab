namespace ne_pridumal{
    struct Team {
        public string Surname; public double Result;
        public Team(string surname, double result) {
            Surname = surname; 
            Result = result;
        }
    }
    class Program{
    static void Main(){
        List<Team> g1 = new List<Team>() { new Team("Иванов", 1.30),new Team("Кузнецов", 1.20),new Team("Райт", 1.15)};
        List<Team> g2 = new List<Team>() { new Team("Мармеладов", 2.00), new Team("Долгополов", 2.30), new Team("Каргин", 3.00) };
        g1.OrderBy(a => a.Result);
        g2.OrderBy(a => a.Result);
        List<Team> g3 = new List<Team>();
        g3.AddRange(g1);
        g3.AddRange(g2);
        foreach(Team team in g3.OrderBy(a=>a.Result))
        {
            Console.WriteLine($"{team.Surname,-10}| {team.Result}");
        }
        }
    }
}
