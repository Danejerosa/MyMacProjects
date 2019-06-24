using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int zebra = -1238;
            int news = ReverseInt(zebra);
            Console.WriteLine(news);
        }

        static int ReverseInt(int n)
		{
            string non = "";
            if (n > 0)
            {
                non = n.ToString();
            }
            else
            {
                non = n.ToString();
                non = non.Substring(1);
            }


            char[] inserter = new char[non.Length];
            char[] reversed = new char[non.Length];
            inserter = non.ToCharArray();

            int counter = non.Length - 1;
            for(int i = 0; i < non.Length; i++)
            {
                
                reversed[counter] = inserter[i];
                counter--;
            }
            string temp = "";
            for(int i = 0; i < reversed.Length; i++)
            {
                temp = temp + reversed[i];
            }
            
            int num = n;
            
            bool result = Int32.TryParse(temp.ToString(), out n);
            if(num < 0)
            {
                n = 0 - n;
            }
            
            
          

            return n;
		}
    }
}
