void FillArray(int[,] array)
{
	Random rand = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i,j] = rand.Next(-100,101);
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

int SumDiagonal(int[,] array)
{
	int result = 0;
	for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
			result += array[i, i];
	return result;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array);
PrintArray(array);
Console.WriteLine($"\nСумма элементов на диагонали: {SumDiagonal(array)}");
