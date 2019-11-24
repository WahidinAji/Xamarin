using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionXamarinApp2.ViewModels
{
    public class ViewModel
    {
        public List<Person> Data { get; set; }
        public ViewModel()
        {

            Data = new List<Person>()
            {
                new Person("John", 160),
                new Person("David", 175),
                new Person("Michael", 180),
                new Person("Smith", 150)
            };
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public Person(string name, double height)
        {
            this.Name = name;
            this.Height = height;
        }
    }
}
