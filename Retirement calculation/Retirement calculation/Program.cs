using System;

namespace Retirement_calculation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            var retiler1 = new Person(65, 40 , "Bob");

            Func<int, int, double> pensionCalculatorUkraine = CalculatePension.Ukraine;
            Func<int, int, double> pensionCalculatorUSA = CalculatePension.USA;
            Func<int, int, double> pensionCalculatorGermany = CalculatePension.Germany;

            double pensionUkraine = retiler1.GetRetiremetnValue(pensionCalculatorUkraine);
            double pensionUSA = retiler1.GetRetiremetnValue(pensionCalculatorUSA);
            double pensionGermany = retiler1.GetRetiremetnValue(pensionCalculatorGermany);

            Console.WriteLine($"Pension in Ukraine in $: {pensionUkraine}");
            Console.WriteLine($"Pension in USA in $: {pensionUSA}");
            Console.WriteLine($"Pension in Germany in $: {pensionGermany}");
        }
    }
}