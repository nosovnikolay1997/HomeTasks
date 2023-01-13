Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = -n;
if (n < 0)
{
	i = n;
	n = -n;
}
while (i <= n)
{
	Console.Write($"{i} ");
	i++;
}
Console.WriteLine();
