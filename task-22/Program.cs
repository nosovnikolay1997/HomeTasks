Console.Clear();
Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
	Console.Write("Ошибка\nВведите целое положительное число: ");
	n = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i < n; i++)
	Console.Write($"{i*i}, ");
Console.WriteLine($"{n*n}");
