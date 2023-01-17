Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int rem = a % b;
if (rem == 0)
	Console.WriteLine($"{b} кратно {a}");
else
	Console.WriteLine($"{b} не кратно {a}, остаток {rem}");
