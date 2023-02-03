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

void FlipHorizontally(int[,] array)
{
	for (int i = 0; i < array.GetLength(0) / 2; i++)
		for (int j = 0; j < array.GetLength(1); j++)
		{
			int buf = array[i, j];
			array[i, j] = array[array.GetLength(0) - i - 1, j];
			array[array.GetLength(0) - i - 1, j] = buf;
		}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
Console.WriteLine("Исходный массив:");
FillArray(array, 10, 100);
PrintArray(array);
FlipHorizontally(array);
Console.WriteLine("\nТранспонированный массив:");
PrintArray(array);
