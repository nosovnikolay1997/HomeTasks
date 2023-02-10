int Ackermann(int m, int n)
{
	if (m == 0)
		return n + 1;
	if (n == 0)
		return Ackermann(m - 1, 1);
	return Ackermann(m - 1, Ackermann(m, n - 1));
}
Console.Clear();
Console.Write("Введите два натуральных числа: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"A({input[0]}, {input[1]}) = {Ackermann(input[0], input[1])}");
