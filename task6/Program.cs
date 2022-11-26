Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double m = n % 2;
if (m == 0)
    Console.WriteLine("Это число чётное");
else 
    Console.WriteLine("Это число нечётное");