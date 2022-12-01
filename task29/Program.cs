Console.Clear();
int[] array = new int[8];
int i = 0;
for(i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
string ar = string.Join(", ", array);
Console.WriteLine($"[{ar}]");