int Min(int a, int b)
{
	if (a < b)
		return a;
	return b;
}

int[,] FillArray(int[,] array, int from, int to)
{
	int[,] dictionary = new int[Min(to - from, array.GetLength(0) * array.GetLength(1)), 3];
	Random rand = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rand.Next(from, to);
			for (int k = 0; k < dictionary.GetLength(0); k++)
				if (dictionary[k, 0] == 0)
				{
					dictionary[k, 0] = 1;
					dictionary[k, 1] = array[i, j];
					dictionary[k, 2] = 1;
					break;
				}
				else
					if (dictionary[k, 1] == array[i, j])
					{
						dictionary[k, 2]++;
						break;
					}
		}
	return dictionary;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write($"{array[i,j]} ");
		Console.WriteLine();
	}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
int[,] dict = FillArray(array, -5, 6);
PrintArray(array);
Console.WriteLine("\nСловарь:");
for (int i = 0; i < dict.GetLength(0); i++)
{
	if (dict[i, 0] == 0)
		break;
	Console.WriteLine($"Число {dict[i, 1]} встречается {dict[i, 2]} раз.");
}
