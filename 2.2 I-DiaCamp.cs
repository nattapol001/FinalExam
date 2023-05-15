using System;

class Program
{
    static void Main(string[] args)
    {
        double B1, B2, B3;

        // รับค่ายอดเบ็ดเตล็ดทั้ง 3 จำนวน
        Console.Write("Enter Balance 1: ");
        B1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Balance 2: ");
        B2 = double.Parse(Console.ReadLine());
        Console.Write("Enter Balance 3: ");
        B3 = double.Parse(Console.ReadLine());

        double payment;
        double remainingBalance = B1;

        // รับยอดชำระในใบเสร็จหรือใบสำคัญรับเงินแต่ละใบ
        while (true)
        {
            Console.Write("Enter payment amount (0 to exit): ");
            payment = double.Parse(Console.ReadLine());

            // หายอดเบ็ดเตล็ดคงเหลือในแต่ละยอด
            if (remainingBalance >= payment)
            {
                remainingBalance -= payment;
            }
            else
            {
                // หายอดเบ็ดเตล็ดที่ไม่สามารถเบิกจ่ายได้
                double leftBalance = payment - remainingBalance;
                remainingBalance = 0;

                Console.WriteLine($"Left: {leftBalance}");
            }

            // ตรวจสอบว่ายอดเบ็ดเตล็ดในแต่ละยอดเหลือเพียงพอหรือไม่
            if (remainingBalance <= 0)
            {
                break;
            }
        }

        // แสดงผลลัพธ์
        Console.WriteLine($"Balance 1: {B1}, Balance 2: {B2}, Balance 3: {B3}");
    }
}