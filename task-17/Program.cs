Console.Clear();
Console.WriteLine("Введите координату X != 0: ");
double x = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
	Console.WriteLine("Ошибка!\nВведите координату X != 0: ");
	x = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите координату Y != 0: ");
double y = Convert.ToDouble(Console.ReadLine());
while (y == 0)
{
	Console.WriteLine("Ошибка!\nВведите координату Y != 0: ");
	y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0)
	if (y > 0)
		Console.WriteLine("1");
	else
		Console.WriteLine("4");

else
	if (y > 0)
		Console.WriteLine("2");
	else
		Console.WriteLine("3");
