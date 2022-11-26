Console.Clear();
Console.WriteLine("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.WriteLine("Необходимо ввести цифру от 1 до 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n <= 5)
    Console.WriteLine("Нет");
if (n >= 6)
    Console.WriteLine("Да");