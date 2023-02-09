void FillArray(int[,] array)
{
	int rightLimit = array.GetLength(1) - 1;
	int downLimit = array.GetLength(0) - 1;
	int leftLimit = 0;
	int upLimit = 1;
	int i = 0;
	int j = -1;
	int count = 1;
	
	while (leftLimit <= rightLimit && upLimit <= downLimit)
	{
		//going right
		for (j++; j <= rightLimit; j++)
		{
			array[i, j] = count;
			count++;
		}
		j--;

		//going down
		for (i++; i <= downLimit; i++)
		{
			array[i, j] = count;
			count++;
		}
		i--;

		//going left
		for (j--; j >= leftLimit; j--)
		{
			array[i, j] = count;
			count++;
		}
		j++;
		
		//going up
		for (i--; i >= upLimit; i--)
		{
			array[i, j] = count;
			count++;
		}
		i++;
		
		rightLimit--;
		downLimit--;
		leftLimit++;
		upLimit++;
	}
}

void PrintArray(int[,] array)
{
	int padding = $"{array.GetLength(0) * array.GetLength(1)}".Length + 1;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write($"{array[i,j]} ".PadLeft(padding));
		Console.WriteLine();
	}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array);
PrintArray(array);
