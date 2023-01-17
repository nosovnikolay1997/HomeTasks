Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int rem = a % b;
if (rem == 0)
	Console.WriteLine($"{a} кратно {b}");
else
	Console.WriteLine($"{a} не кратно {b}, остаток {rem}");
