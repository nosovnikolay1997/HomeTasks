Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 7 == 0) && (n % 23 == 0))
	Console.WriteLine("Да");
else
	Console.WriteLine("Нет");
