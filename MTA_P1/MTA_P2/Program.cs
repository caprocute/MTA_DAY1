using System;

namespace MTA_P2
{
    class Program
    {
        private static float salary;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhập vào điểm tổng kết của học viên: ");
                salary = float.Parse(Console.ReadLine());

                if (salary > 70 && salary <= 100)
                {
                    Console.WriteLine("Xếp loại Giỏi!");

                }
                else
                if (salary >= 70 && salary <= 79)
                {
                    Console.WriteLine("Xếp loại khá!");

                }
                else if (salary >= 60 && salary <= 69)
                {
                    Console.WriteLine("Xếp loại TB khá!");

                }
                else if (salary > 50 && salary <= 59)
                {
                    Console.WriteLine("Xếp loại TB!");

                }
                else if (salary < 50)
                {
                    Console.WriteLine("Xếp loại Yếu!");

                }
                else
                {
                    Console.WriteLine("Không hợp lệ!");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi xảy ra, liên hệ tổng đài để được hỗ trợ");
            }
        }
    }
}
