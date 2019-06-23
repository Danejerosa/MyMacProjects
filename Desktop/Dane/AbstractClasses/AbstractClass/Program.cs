using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Resident Dane = new Resident();
            NonResident Ling = new NonResident();


            double balance = Dane.tuition(3);
            Console.WriteLine(balance);

            balance = Ling.tuition(3);
            Console.WriteLine(balance);



        }
    }
}
