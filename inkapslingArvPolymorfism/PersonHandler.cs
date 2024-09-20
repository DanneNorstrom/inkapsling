using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkapslingArvPolymorfism
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstname(Person pers, string firstname)
        {
            pers.Fname = firstname;
        }

        public void SetLastname(Person pers, string lastname)
        {
            pers.Lname = lastname;
        }

        public void SetHeight(Person pers, double height) 
        { 
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname,
        string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age;
            p.Fname = fname;
            p.Lname = lname;
            p.Height = height;
            p.Weight = weight;
            return p;
        }
        public void PrintPerson(Person p)
        {
            Console.WriteLine(p.Age.ToString());
            Console.WriteLine(p.Fname);
            Console.WriteLine(p.Lname);
            Console.WriteLine(p.Height.ToString());
            Console.WriteLine(p.Weight.ToString());
        }
    }
}
