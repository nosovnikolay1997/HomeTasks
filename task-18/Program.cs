Console.Clear();
Console.WriteLine("Введите целое число от 1 до 4: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
	Console.WriteLine("Ошибка!\nВведите ыелое число от 1 до 4: ");
	n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
	Console.WriteLine("X - (0, +inf)\nY - (0, +inf)");
else if (n == 2)
	Console.WriteLine("X - (-inf, 0)\nY - (0, +inf)");
else if (n == 3)
	Console.WriteLine("X - (-inf, 0)\nY - (-inf, 0)");
else if (n == 4)
	Console.WriteLine("X - (0, +inf)\nY - (-inf, 0)");
