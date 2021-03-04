using System;

namespace MTA_P3
{
    class Program
    {
        private static float salary;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhập vào số điện của hộ gia đình: ");
                salary = float.Parse(Console.ReadLine());
                float bill = 0;
                int step = 1;
                while (salary > 0)
                {
                    if (step == 1)
                    {
                        if (salary <= 100)
                        {
                            bill += salary * 450;
                            salary += -100;
                            break;
                        }
                        else
                        {
                            bill += 45000;
                            salary += -100;
                        }
                    }

                    if (step == 2)
                        if (salary <= 100) { bill += salary * 600; salary += -100; }
                        else { bill += 600*99; salary += -100; }

                    if (step == 3)
                        if (salary <= 100) { bill += salary * 750; salary += -100; }
                        else { bill += 750*99; salary += -100; }

                    if (step == 4)
                        if (salary <= 200 && step == 4) { bill += salary * 900; salary += -200; }
                        else { bill += 900+199; salary += -200; }


                    if (step == 5)
                        if (salary <= 500) { bill += salary * 1000; salary += -500; }
                        else { bill += 100+499; salary += -500; }

                    if (step >= 6) { bill += salary * 1200; salary += -long.MaxValue; }
                    step += 1;

                }
                Console.WriteLine("Số tiền điện phải trả là:" + bill);
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi xảy ra, liên hệ tổng đài để được hỗ trợ");
            }
        }
    }
}
