Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
	Console.Write("Ошибка!\nВведите трёхзначное число: ");
	n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Вторая цифра: {(n / 10) % 10}");
