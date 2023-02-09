void FillArray(int[,,] array)
{
	int count = 10;
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			for (int k = 0; k < array.GetLength(2); k++)
			{
				array[i, j, k] = count;
				count++;
			}
}

void PrintArray(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
				Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
Console.Clear();
Console.Write("Введите размеры трёхмерного массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] array = new int[input[0], input[1], input[2]];
FillArray(array);
PrintArray(array);
