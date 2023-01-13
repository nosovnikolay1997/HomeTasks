Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число: ");
if (a > b)
	Console.WriteLine(a);
else
	Console.WriteLine(b);
