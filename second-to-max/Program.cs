Console.Clear();
Console.WriteLine("Введите 3 или более неотрицательных целых числа, каждое на новой строке, последнее число - 0:");
int n = Convert.ToInt32(Console.ReadLine());
int first_max = 0;
int second_max = -1;
while (n > 0)
{
	if (n > first_max)
	{
		second_max = first_max;
		first_max = n;
	}
	else if (n > second_max)
		second_max = n;
	n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Второе максимальное число: {second_max}");
