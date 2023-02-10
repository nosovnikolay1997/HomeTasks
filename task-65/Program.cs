void PrintSequence(int from, int to)
{
	if (to > from)
	{
		PrintSequence(from, to-1);
		Console.Write(", ");
	}
	Console.Write($"{to}");
}

Console.Clear();
Console.Write("Введите два натуральных числа: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
PrintSequence(input[0], input[1]);
Console.WriteLine();
