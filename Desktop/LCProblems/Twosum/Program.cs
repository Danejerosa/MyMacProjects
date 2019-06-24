using System;

namespace Twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 13;

            int[] arrs = new int[6] { 1, 5, 9, 8, 2, 6 };
            int[] temp = new int[2];

            temp = Twosum(arrs, target);

            Console.WriteLine(temp[0] + " " + temp[1]);


        }

        static int[] Twosum(int[] arr, int target)
        {
            int[] temp = new int[2];


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                        temp[0] = i;
                        temp[1] = j + 1;
                    }
                }
            }


            return temp;
        }

    }
    
}
