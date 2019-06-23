using System;
namespace AbstractClass
{
    public abstract class Student
    {
        public Student()
        {
        }

        public abstract double tuition(int n);
        
    }


    public class Resident:Student 
    {
        public override double tuition(int n)
        {
            double balance = 568 * n;
            if (n > 2)
            {
                balance = balance - (balance * .20);
            }

            return balance;
        }
       
    }

    public class NonResident:Student
    {
        public override double tuition(int n)
        {
            double balance = 1563 * n;
            if(n > 2)
            {
                balance = balance - (balance * .20);
            }
            return balance;
        }
    }

}
