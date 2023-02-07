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

bool Transpose(int[,] array)
{
	if (array.GetLength(0) != array.GetLength(1))
		return false;
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = i; j < array.GetLength(1); j++)
		{
			int buf = array[i, j];
			array[i, j] = array[j, i];
			array[j, i] = buf;
		}
	return true;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
Console.WriteLine("До замены:");
PrintArray(array);
if (Transpose(array))
{
	Console.WriteLine("\nПосле замены:");
	PrintArray(array);
}
else
	Console.WriteLine("\nЗамена невозможна!");
