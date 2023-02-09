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

int RowSum(int[,] array, int i)
{
	int sum = 0;
	for (int j = 0; j < array.GetLength(1); j++)
		sum += array[i, j];
	return sum;
}

int MinRow(int[,] array)
{
	int res = 0;
	for (int i = 1; i < array.GetLength(0); i++)
		if (RowSum(array, i) < RowSum(array, res))
			res = i;
	return res;
}

string RowToString(int[,] array, int i)
{
	string res = $"{array[i, 0]}";
	for (int j = 1; j < array.GetLength(1); j++)
		res += $" {array[i, j]}";
	return res;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 1, 10);
PrintArray(array);
int minRow = MinRow(array);
Console.WriteLine($"\nСтрока {minRow + 1} ({RowToString(array, minRow)}) имеет наименьшую сумму ({RowSum(array, minRow)}).");
