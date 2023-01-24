Console.Clear();
Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 2; i <= n; i++)
	res = res * i;
Console.WriteLine($"Произведение чисел от 1 до {n}: {res}");
