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
			Console.Write($"{array[i,j]} ");
		Console.WriteLine();
	}
}

void SortArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		// bubble sort
		for (int j = 0; j < array.GetLength(1); j++)
			for (int k = 0; k < array.GetLength(1) - 1; k++)
				if (array[i, k] < array[i, k+1])
				{
					int buf = array[i, k];
					array[i, k] = array[i, k+1];
					array[i, k+1] = buf;
				}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
Console.WriteLine("До сортировки:");
PrintArray(array);
SortArray(array);
Console.WriteLine("\nПосле сортировки:");
PrintArray(array);
