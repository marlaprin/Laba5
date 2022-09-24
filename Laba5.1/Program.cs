using System;
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
const int r = 1;
// x^2 + y^2 = r^2;
// x = Math.Sqrt(r**r - y**y);
// y = Math.Sqrt(r**r - x**x);
if ((x >= 0) && (y >= 0) && (x*x + y*y <= r*r))
{
    Console.WriteLine("Точка с координатами O(x; y) принадлежит второй четверти единичной окружности.");
}
else
{
    Console.WriteLine("Точка с координатами O(x; y) не принадлежит второй четверти единичной окружности!");
}