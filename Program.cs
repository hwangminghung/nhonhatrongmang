using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap kich thuoc cua mang:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Nhap cac phan tu cua mang:");

        // Nhap gia tri cho tung phan tu cua mang
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Nhap gia tri cho phan tu thu {i}:");
            array[i] = int.Parse(Console.ReadLine());
        }

        int minValue = FindMinValue(array);

        Console.WriteLine($"Gia tri nho nhat trong mang la {minValue}.");
    }

    static int FindMinValue(int[] array)
    {
        int minValue = array[0];

        // Tim gia tri nho nhat trong mang
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }
}