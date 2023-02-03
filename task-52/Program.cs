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

double[] RowAverage(int[,] array)
{
	double[] result = new double[array.GetLength(1)];
	for (int i = 0; i < array.GetLength(1); i++)
	{
		result[i] = 0;
		for (int j = 0; j < array.GetLength(0); j++)
			result[i] += array[j,i];
		result[i] /= array.GetLength(0);
	}
	return result;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
PrintArray(array);
Console.WriteLine($"\nСреднее арифметическое каждого столбца:\n{string.Join(", ", RowAverage(array))}");
