using System;
public class Program
{
    public static void Main()
 {
        double start, end, step;
        Console.WriteLine("Введіть початкове значення кута (в граду-сах): ");
        start = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть кінцеве значення кута (в градусах): ");
        end = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Введіть крок зміни кута (в градусах): ");
        step = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0,10} | {1,10}", "Кут (градуси)", "ctg(x)");
        double x = start;
        do
        {
            double radians = x * Math.PI / 180.0;
            if (Math.Abs(x % 180) == 90)
            {
                Console.WriteLine("{0,10:F2} | {1,10}", x, "невизначено");
            }
            else
            {
                double cotangent = 1.0 / Math.Tan(radians);
                Console.WriteLine("{0,10:F2} | {1,10:F4}", x, cotangent);
            }
            x += step;
        } while (x <= end);
   // Додаємо нове повідомлення
        Console.WriteLine("\nПрограма завершена.");
    }
}
