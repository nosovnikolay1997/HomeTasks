int fib(int n)
{
	if (n < 2)
		return n;
	return fib(n - 1) + fib(n - 2);
}

Console.Clear();
Console.Write("Введите неотрицательное число: ");
Console.WriteLine($"{fib(Convert.ToInt32(Console.ReadLine()))}");
