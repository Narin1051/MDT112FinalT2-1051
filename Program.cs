namespace WaterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double Vmax, Vdrink, Vavg, Vfill;
            double tdrink, tpause, ttotal, tfill;
            double waterLeft = 0;

            // รับค่าจากผู้ใช้
            Console.Write("Enter Vmax: ");
            Vmax = double.Parse(Console.ReadLine());

            Console.Write("Enter Vdrink: ");
            Vdrink = double.Parse(Console.ReadLine());

            Console.Write("Enter Vavg: ");
            Vavg = double.Parse(Console.ReadLine());

            Console.Write("Enter Vfill: ");
            Vfill = double.Parse(Console.ReadLine());

            Console.Write("Enter tdrink: ");
            tdrink = double.Parse(Console.ReadLine());

            Console.Write("Enter tpause: ");
            tpause = double.Parse(Console.ReadLine());

            Console.Write("Enter ttotal: ");
            ttotal = double.Parse(Console.ReadLine());

            Console.Write("Enter tfill: ");
            tfill = double.Parse(Console.ReadLine());

            // คำนวณปริมาตรน้ำที่ต้องการเติม
            double Vneed = Vavg * (ttotal / (tdrink + tpause));

            // คำนวณเวลาที่เหลือในการดื่มน้ำ
            double tleft = ttotal - ((tdrink + tpause) * Math.Floor(ttotal / (tdrink + tpause)));

            // คำนวณปริมาตรน้ำที่ต้องเติมในรอบสุดท้าย
            double Vlast = Vmax - waterLeft;

            // คำนวณเวลาที่ต้องใช้ในการเติมน้ำ
            double tfillNeed = Vneed / Vfill;

            // ตรวจสอบว่าเติมน้ำครบหรือไม่
            if (Vneed <= Vlast)
            {
                waterLeft += Vneed;
                Console.WriteLine("Enough Water, {0} left", Vmax - waterLeft);
            }
            else
            {
                waterLeft = Vmax;
                Console.WriteLine("Not Enough Water");
            }

            // ตรวจสอบว่าถังน้ำเต็มหรือไม่
            if (Vfill * tfillNeed <= Vmax - waterLeft)
            {
                waterLeft += Vfill * tfillNeed;
            }
            else
            {
                Console.WriteLine("Overflow Water");
            }
        }
    }
}