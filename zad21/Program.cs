Console.WriteLine("Введите координаты точки А (x, y, z):");
int[] point_a = new int[3];
int[] point_b = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Коородината : ");
    point_a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты точки B (x, y, z):");
for (int i = 0; i < 3; i++)
{
    Console.Write("Коородината : ");
    point_b[i] = Convert.ToInt32(Console.ReadLine());
}
double dist = 0;
for (int i = 0; i < 3; i++) dist = dist + Math.Pow(point_a[i] - point_b[i], 2);
dist = Math.Round(Math.Sqrt(dist), 2);
Console.WriteLine($"Расстояние между точками равно: {dist}");

