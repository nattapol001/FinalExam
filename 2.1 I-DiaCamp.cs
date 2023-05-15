using System;

class Program
{
    static void Main(string[] args)
    {
        double Vmax, VdrinkAvg, Vfill;
        double tdayDrink, tdayFill, tTotal;

        // รับค่าจากผู้ใช้
        Console.Write("Enter Vmax: ");
        Vmax = double.Parse(Console.ReadLine());
        Console.Write("Enter VdrinkAvg: ");
        VdrinkAvg = double.Parse(Console.ReadLine());
        Console.Write("Enter Vfill: ");
        Vfill = double.Parse(Console.ReadLine());

        Console.Write("Enter tdayDrink: ");
        tdayDrink = double.Parse(Console.ReadLine());
        Console.Write("Enter tdayFill: ");
        tdayFill = double.Parse(Console.ReadLine());
        Console.Write("Enter tTotal: ");
        tTotal = double.Parse(Console.ReadLine());

        // คำนวณปริมาณน้ำที่เหลือ
        double remainingWater = Vmax - (VdrinkAvg * tdayDrink) + (Vfill * tdayFill);
        
        // ตรวจสอบว่ามีน้ำเพียงพอหรือไม่
        if (remainingWater >= 0)
        {
            Console.WriteLine($"Enough Water, {remainingWater} left");
        }
        else if (remainingWater < 0 && remainingWater >= -Vfill)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }
    }
}
