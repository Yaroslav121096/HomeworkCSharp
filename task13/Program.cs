Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(n);
char[] m = str.ToCharArray();
int i = 0;
while (i < 2)
    i++;
if (n < 99)
    Console.WriteLine("Третьей цифры нет!");
else
    Console.WriteLine(m[i]);