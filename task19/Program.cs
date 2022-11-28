Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int rev = 0;
while (n > 0)
{
    rev = rev * 10 + n % 10;
    n /= 10;
}
if (m == rev)
    Console.WriteLine("Это число является палиндромом");
else
    Console.WriteLine("Это число не является палиндромом");