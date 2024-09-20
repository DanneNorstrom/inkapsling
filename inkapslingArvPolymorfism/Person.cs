using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkapslingArvPolymorfism
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get 
            {
                return age;
            }
            set 
            {
                if (value > 0) 
                {
                    age = value;
                }
                else 
                {
                    //todo: implementera exceptions
                    Console.WriteLine("validation error!");
                }
            }
        }
        public string Fname 
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10) Console.WriteLine("validation error:");
                else fName = value;
            }
        }
        public string Lname
        {
            get
            { 
                return lName;
            }

            set
            {
                if (value.Length < 3 || value.Length > 15) Console.WriteLine("validation error:");
                else lName = value;
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
