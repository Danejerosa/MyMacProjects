using System;
namespace Inheritance
{
    public class Student
    {
        int iD = 0;
        string name = "";
        string country = "";

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; ; }
        }

        public double GetTuition(int n)
        {
            double tuition = n * 568;
            
            if (n > 2)
            {
                tuition = tuition - (tuition * .15);
            }
            return tuition;
        }
        
    }
}
