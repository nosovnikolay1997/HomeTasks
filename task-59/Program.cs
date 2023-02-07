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

int[] FindIndexOfMin(int[,] array)
{
	int[] res = new int[2];
	res[0] = 0;
	res[1] = 0;
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			if (array[i,j] < array[res[0], res[1]])
			{
				res[0] = i;
				res[1] = j;
			}
	return res;
}

int[,] RemoveRowAndColumn(int[,] array, int i, int j)
{
	int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
	int res_i = 0;
	for (int inp_i = 0; inp_i < array.GetLength(0); inp_i++)
		if (inp_i != i)
		{
			int res_j = 0;
			for (int inp_j = 0; inp_j < array.GetLength(1); inp_j++)
				if (inp_j != j)
				{
					res[res_i, res_j] = array[inp_i, inp_j];
					res_j++;
				}
			res_i++;
		}
	return res;
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
Console.WriteLine("До удаления:");
PrintArray(array);
int[] min = FindIndexOfMin(array);
Console.WriteLine($"\nМинимальное число на ({min[1]+1}, {min[0]+1}): {array[min[0], min[1]]}\n\nПосле удаления:");
int[,] res_array = RemoveRowAndColumn(array, min[0], min[1]);
PrintArray(res_array);
