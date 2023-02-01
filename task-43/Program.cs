Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
	if (b1 == b2)
		Console.WriteLine("Прямые совпадают.");
	else
		Console.WriteLine("Прямые параллельны.");
else
	Console.WriteLine($"Точка пересечения: ({(b2-b1)/(k1-k2)}; {(k1*b2-k2*b1)/(k1-k2)})");
