Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
	Console.Write($"{i} ");
	i += 2;
}
Console.WriteLine();
