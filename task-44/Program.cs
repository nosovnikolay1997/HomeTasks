Console.Clear();
Console.Write("Введите номер числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int previous = 0;
for (int current = 1; n > 0; n--)
{
	Console.Write($"{previous} ");
	int next = previous + current;
	previous = current;
	current = next;
}
Console.WriteLine();
