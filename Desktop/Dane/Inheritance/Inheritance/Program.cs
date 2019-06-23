using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Marshall = new Student();

            Marshall.Name = "Marshall";
            InternationalStudent Xiong = new InternationalStudent();
            Xiong.Name = "Xiong";

            Console.WriteLine(Marshall.Name);
            Console.WriteLine(Xiong.Name);

            double tuition = Marshall.GetTuition(3);
            Console.WriteLine(tuition);

            tuition = Xiong.GetInternationalTuition(3);
            Console.WriteLine(tuition);
        }
    }
}
