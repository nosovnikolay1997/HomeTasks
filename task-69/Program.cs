int Power(int a, int b)
{
	if (b == 0)
		return 1;
	return a * Power(a, b - 1);
}

Console.Clear();
Console.Write("Введите два натуральных числа: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"{input[0]}^{input[1]}={Power(input[0], input[1])}");
