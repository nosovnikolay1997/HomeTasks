void PrintSequence(int n)
{
	if (n > 1)
	{
		PrintSequence(n - 1);
		Console.Write(", ");
	}
	Console.Write($"{n}");
}

Console.Clear();
Console.Write("Введите натуральное число: ");
PrintSequence(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
