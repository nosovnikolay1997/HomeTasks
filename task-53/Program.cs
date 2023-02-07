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

void ChangeFirstAndLast(int[,] array)
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		int buf = array[0, i];
		array[0, i] = array[array.GetLength(0) - 1, i];
		array[array.GetLength(0) - 1, i] = buf;
	}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
Console.WriteLine("До перемены:");
PrintArray(array);
Console.WriteLine("\nПосле перемены:");
ChangeFirstAndLast(array);
PrintArray(array);
