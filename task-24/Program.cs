Console.Clear();
Console.Write("Введите положительное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
	sum += i;
Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}");
