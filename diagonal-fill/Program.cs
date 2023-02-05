void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write($"{array[i, j]} ");
		Console.WriteLine();
	}
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
int counter = 0;
for (int i = 0; i < array.GetLength(0) + array.GetLength(1) - 1; i++)
{
	int currentX = i;
	int currentY = 0;
	if (i >= array.GetLength(1))
	{
		currentX = array.GetLength(1) - 1;
		currentY = i - array.GetLength(1) + 1;
	}
	while (currentX >= 0 && currentY < array.GetLength(0))
	{
		array[currentY, currentX] = counter;
		counter++;
		currentX--;
		currentY++;
	}
}
PrintArray(array);
