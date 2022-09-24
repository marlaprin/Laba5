using System;
Random rnd = new Random(DateTime.Now.Millisecond);
int[] a = new int[100];
int count = 0;
int sum = 0;
for (int i = 0; i < 100; i++)
{
    a[i] = rnd.Next(-1001, 1001);
    if (a[i] % 2 == 0)
    {
        count += a[i];
        Console.WriteLine("Количество чётных чисел в массиве ->", count);
    }
    if (a[i] % 3 == 0)
    {
        count += a[i];
        Console.WriteLine("Количество чисел кратных 3-ём в массиве ->", count);
    }

    if (a[i] < 0)
    {
        count += a[i];
        sum += a[i];
    }
    else
    {
        Console.WriteLine("Eror!");
    }
}
Console.WriteLine("Количество нечётных в массиве чисел:", count, "и сумма нечётных в массиве чисел:", sum);



