int Sum(int m, int n)
{
	if (m == n)
		return m;
	return n + Sum(m, n-1);
}
Console.Clear();
Console.Write("Введите два натуральных числа: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"Сумма натуральных элементов от {input[0]} до {input[1]}: {Sum(input[0], input[1])}");
