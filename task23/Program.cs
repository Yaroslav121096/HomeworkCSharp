Console.Clear();
Console.Clear();
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i + 1 > n)
        Console.Write($"{Math.Pow(i, 3)}.");
    else
        Console.Write($"{Math.Pow(i, 3)}, ");
}