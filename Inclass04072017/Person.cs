using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass04072017
{
    class Person
    {
        public string name;
        public int age;
        public string homeTown;
        public string favFood;

        public Person()//Default constructor
        {

        }

        public Person(string name, int age, string homeTown, string favFood)//Constructor with parameters
        {
            this.name = name;
            this.age = age;
            this.homeTown = homeTown;
            this.favFood = favFood;

        }
    }
    
}
