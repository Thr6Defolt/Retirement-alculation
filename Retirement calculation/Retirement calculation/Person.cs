using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement_calculation
{
    internal class Person
    {
        public string Name{get; set;}
        public int Age {get; set;}
        public int Experience {get; set;}
        public Person(int age, int experience, string name)
        {
            Name = name;
            Age = age;
            Experience = experience;
        }
        public double GetRetiremetnValue(Func<int, int, double> pensionCalculator)
        {
            return pensionCalculator(Age, Experience);
        }
    }
}
