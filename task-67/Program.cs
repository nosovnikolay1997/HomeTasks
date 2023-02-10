int SumOfDigits(int n)
{
	if (n == 0)
		return 0;
	return SumOfDigits(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр: {SumOfDigits(n)}");
