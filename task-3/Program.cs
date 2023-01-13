Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
	Console.Write("Ошибка!\nВведите число от 1 до 7: ");
	n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
	Console.WriteLine("Понедельник");
else if (n == 2)
	Console.WriteLine("Вторник");
else if (n == 3)
	Console.WriteLine("Среда");
else if (n == 4)
	Console.WriteLine("Четверг");
else if (n == 5)
	Console.WriteLine("Пятница");
else if (n == 6)
	Console.WriteLine("Суббота");
else
	Console.WriteLine("Воскресенье");
