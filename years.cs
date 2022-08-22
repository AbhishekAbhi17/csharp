using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            int age_after_10_years, your_age;
            Console.Write("Enter the value of your age: ");
            your_age = int.Parse(Console.ReadLine());
            age_after_10_years=your_age+10;
            Console.WriteLine("Value of age after 10 years: " + age_after_10_years);
            Console.WriteLine();
            Console.Write("Press any key to finish . . . ");
            Console.ReadKey();
        }
    }
}

