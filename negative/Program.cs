void FillArray(int[,] array, int from, int to)
{
	Random rand = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i,j] = rand.Next(from, to);
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			if (array[i, j] > 0)
				Console.Write("W ");
			else
				Console.Write("B ");
		Console.WriteLine();
	}
}

int Compare(int[,] a, int[,] b)
{
	int result = 0;
	for (int i = 0; i < a.GetLength(0) && i < b.GetLength(1); i++)
		for (int j = 0; j < a.GetLength(1) && j < b.GetLength(1); j++)
			if (a[i, j] == b[i, j])
				result++;
	return result;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] source = new int[input[0], input[1]];
Console.WriteLine("Исходный массив:");
FillArray(source, 0, 2);
PrintArray(source);
Console.WriteLine("\nНегатив:");
int[,] negative = new int[input[0], input[1]];
FillArray(negative, 0, 2);
PrintArray(negative);
Console.WriteLine($"\nНесоответствий: {Compare(source, negative)}");
