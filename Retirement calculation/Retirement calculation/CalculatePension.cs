using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement_calculation
{
    internal class CalculatePension
    {
        public static double Ukraine(int age, int experience)
        {
            return (age * 10) + (experience * 5);
        }

        public static double USA(int age, int experience)
        {
            return (age * 20) + (experience * 10);
        }

        public static double Germany(int age, int experience)
        {
            return (age * 15) + (experience * 8);
        }
    }
}
