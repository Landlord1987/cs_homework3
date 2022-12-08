int[] a = new int[3];
int[] b = new int[3];

Console.WriteLine("Введите координаты точки A через Enter: ");
for (int i = 0; i < 3; i++)
{
    Console.Write("A" + (i+1) + ": " );
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки B через Enter: ");
for (int i = 0; i < 3; i++)
{
    Console.Write("B" + (i+1) + ": " );
    b[i] = Convert.ToInt32(Console.ReadLine());
}

calcSegment(a, b);

//Метод расчета длины
void calcSegment(int[] a, int[] b)
{
    double res;
    res = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));
    Console.Write(Math.Round(res, 2));
}