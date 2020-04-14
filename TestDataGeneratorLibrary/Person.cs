using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string getData()
        {
            return $"{firstName} {lastName}, {age} vuotta";
        }
    }
}
