using System;

namespace MTA_P1
{
    class Program
    {
        private static float salary;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhập vào lương của nhân viên");
                salary = float.Parse(Console.ReadLine());
                Console.WriteLine("Lương  bạn vừa nhập là: " + salary);
                if (salary < 500)
                {
                    Console.WriteLine("Bạn không phải nộp thuế");
                }
                else
                {
                    Console.WriteLine("Bạn phải nộp số tiền thuế là: " + (salary * 10 / 100));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi xảy ra, liên hệ tổng đài để được hỗ trợ");
            }
        }
    }
}
