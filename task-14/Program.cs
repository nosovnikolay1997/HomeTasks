Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 161 == 0)
	Console.WriteLine("Да");
else
	Console.WriteLine("Нет");
