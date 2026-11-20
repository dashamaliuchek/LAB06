using System;

namespace LAB06
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        
        public Person(string name, int age) : this(name, age, "Неизвестно")
        {
        }

        
        public Person(string name) : this(name, 0)
        {
        }
        
        public Person() : this("Неизвестно")
        {
        }
        
        public override string ToString()
        {
            return $"Person: {Name}, {Age} лет, {City}";
        }
    }
}