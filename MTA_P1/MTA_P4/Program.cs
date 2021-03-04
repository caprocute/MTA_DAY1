using System;

namespace MTA_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++) {
                sum += i;
            }
            Console.WriteLine("Tổng của 100 số nguyên đầu tiên là: "+sum);
            Console.WriteLine("Các số chia hết cho 3 trong khoảng 20 - 50 là: ");

            int start = 20;
            while (start <= 50) {
                if ((start % 3) == 0)
                {
                    Console.Write(start+" ");
                   
                }
                start++;
            }
        }
    }
}
