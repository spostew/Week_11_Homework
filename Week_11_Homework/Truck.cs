using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Homework
{
    class Truck : Vehicle
    {
        // variables used for assignment and the ToString
        private double loadCapacity;
        private int towingCapacity;
        public int access;
        public string name;
        Truck() { } // default constructor
        public Truck(Person n, int make, int cyclinder, double load, int tow) // loads values into variables
        {
            name = n.getName();
            access = make;
            base.cyclinders = cyclinder;
            loadCapacity = load;
            towingCapacity = tow;
        }

        // getters and setters
        public double getLoad() { return loadCapacity; }
        public int getTow() { return towingCapacity; }
        public void setLoad(double l) { loadCapacity = l; }
        public void setTow(int t) { towingCapacity = t; }

        public override string ToString() // displays the results formatted
        {
            return "Owner: " + name + "\nManufacturer's name: " + (Manufacturer)access + "\nCylinders: " + cyclinders
                + "\nLoad: " + loadCapacity + " tons" + "\nTowing: " + towingCapacity + " pounds";
        }
    }
}
