using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Person
    {
        public string name;
        //public List<string> names;

       /* public Person()
        {
            // names = new List<string>
        }*/
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}", to, name);
        }
        public static Person Parse(string s)
        {
            var person = new Person();
            person.name = s;

            return person;
        }

    }

}
