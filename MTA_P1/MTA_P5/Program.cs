using System;

namespace MTA_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sum = 0;
                int[] input = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Nhập số nguyên thứ " + (i+1));
                    input[i] = int.Parse(Console.ReadLine());
                }
                int max = input[0];
                int postion = 0;
                do
                {
                    postion++;
                    if (input[postion] > max) max = input[postion];
                }
                while (postion < 4);
                Console.WriteLine("Số lớn nhất là: " + max);


                Console.WriteLine("Các số chia hết cho 7 trong khoảng 10 - 70 là: ");

                int start = 10;
                do
                {
                    if ((start % 7) == 0)
                    {
                        Console.Write(start + " ");

                    }
                    start++;
                } while (start <= 70);
            }
            catch(Exception e)
            {
                Console.WriteLine("Có lỗi xảy ra");

            }
        }
    }
}
