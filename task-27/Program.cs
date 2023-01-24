Console.Clear();
Console.Write("Введите неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
	sum += n % 10;
	n = n / 10;
}
Console.WriteLine($"Сумма цифр: {sum}");
