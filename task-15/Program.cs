Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
	Console.WriteLine("Ошибка!\nВведите число от 1 до 7: ");
	n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
	Console.WriteLine("Да");
else
	Console.WriteLine("Нет");
