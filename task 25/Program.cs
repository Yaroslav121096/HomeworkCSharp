Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine($"Число {a} в степени {b} равно: {result}");