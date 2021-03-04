using System;

namespace MTA_P6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float salary;
                Console.WriteLine("Nhập vào số phút gọi: ");
                salary = float.Parse(Console.ReadLine());
                float subSalary = salary;
                float bill = 27000;
                int step = 1;
                while (salary > 0)
                {
                    if (step == 1)
                    {
                        if (salary <= 200)
                        {
                            bill += salary * 120;
                            salary += -100;
                            break;
                        }
                        else
                        {
                            bill += 120 * 200;
                            salary += -200;
                        }
                    }

                    if (step == 2)
                        if (salary <= 199) { bill += salary * 80; salary += -199; }
                        else { bill += 80 * 199; salary += -199; }

                    if (step >= 3) { bill += salary * 40; salary += -long.MaxValue; }
                    step += 1;
                }
                Console.WriteLine("Số tiền cước phải trả là:" + bill);


                Console.WriteLine("Nhập mã khách hàng (0/1):");
                int code =int.Parse(Console.ReadLine());
                if (code == 0)
                {
                    if (subSalary <= 50) bill = 0;
                    else bill=bill-(50*120);

                    Console.WriteLine("Cước sau khuyến mãi:"+bill);
                }
                else Console.WriteLine("Cước sau khuyến mãi:" + bill);


            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi xảy ra, liên hệ tổng đài để được hỗ trợ");
            }
        }
    }
}
