using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass04072017
{
    class Program
    {
        static void Main(string[] args)
        {   //data type, variable name, is new, datatype, constructors.
            Person person1 = new Person("Amy", 30, "Washington, DC", "Chicken");
            Person person2 = new Person("Bob", 22, "Cleveland, OH", "Beef");

            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);
        }
    }
}
