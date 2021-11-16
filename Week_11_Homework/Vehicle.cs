using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Homework
{
   
    class Vehicle
    {
        public enum Manufacturer // Enum that is assigned for various car makes
        {
            Subaru = 0,
            Chevy = 1,
            Ford = 2,
            Mazda = 3,
            Jeep = 4
        }

        public int cyclinders = 0; // store initial value in int

    }

    public class Person // person class that creates a name and assignment functions
    {
        private String name;
        public Person()
        {
            name = "";
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(Person obj) { }

        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public override string ToString()
        {
            return "Name: " + name;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
