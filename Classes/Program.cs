﻿

using System;

namespace Classes
{
 /*
  * public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
 */

    class Program
    {
        static void Main(string[] args)
        {
            // var person = Person.Parse("John");
            //person.Introduce("Mosh");
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
