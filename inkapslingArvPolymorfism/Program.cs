namespace inkapslingArvPolymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Age = 20;

            PersonHandler ph = new PersonHandler();
            Person p1 = ph.CreatePerson(35, "John", "Andersson", 1.85, 85);
            Person p2 = ph.CreatePerson(45, "Siri", "Karlsson", 1.70, 70);

            ph.PrintPerson(p1);

            ph.SetLastname(p1, "Svensson");

            ph.PrintPerson(p1);

            ph.PrintPerson(p2);
        }
    }
}
