Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (n > m && n > x)
    Console.WriteLine($"Max = {n}");
else if (m > n && m > x)
    Console.WriteLine($"Max = {m}");
else if (x > n && x > m)
    Console.WriteLine($"Max = {x}");
if (n == m && n == x)
    Console.WriteLine($"Max = {n}");
else if (m == n && m == x)
    Console.WriteLine($"Max = {m}");
else if (x == n && x == m)
    Console.WriteLine($"Max = {x}");