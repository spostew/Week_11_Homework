/*
 * Vehicle: This program shows inheritance and enums by filling objects and constructors from different classes and displaying the results in the main
 * Name: Spencer Unitt
 * Module: Homework 11 Week 11
 * 
 * Algorithm
 * 1. Create a class named Vehicle that contains an enum of manufacturer names, and an int named cylinder
 * 2. In the vehicle class create a class named person that contains a string called name, getter, setter and override the Tostring
 * 3. Create another class called Truck that contains a double and int called load and tow
 * 4. Use a constructor and assign all the values from the vehicles class and the truck class
 * 5. In the main, test the functions and display the results to the user * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person("Spencer Unitt"); // fills the name variable in the Person class and assigns to the new object
            Person owner1 = new Person("Tom Waits");
            Truck make1 = new Truck(owner, 0, 6, 25, 4000);
            Truck make2 = new Truck(owner1, 4, 4, 15, 2500);

            // displays the results to the user
            Console.WriteLine(owner.ToString() +"\n");
            Console.WriteLine(make1.ToString()+"\n");
            Console.WriteLine(make2.ToString());

            Console.ReadLine();
        
        }
    }
}
