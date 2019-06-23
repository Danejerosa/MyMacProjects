using System;
namespace Inheritance
{
    public class InternationalStudent:Student
    {
        public InternationalStudent()
        {
            Console.WriteLine("Is an international Student");
        }

        public double GetInternationalTuition(int n)
        {
            double tuition = n * 1568;
            if(n > 2)
            {
                tuition = tuition - (tuition * .15);
            }
            return tuition;

        }
    }
}
