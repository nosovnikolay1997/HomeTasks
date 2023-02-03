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

string PickElement(int[,] array, int i, int j)
{
	i--;
	j--;
	if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
		return $"{array[i, j]}";
	else
		return "Такой позиции в массиве нет.";
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] array = new int[input[0], input[1]];
FillArray(array, 10, 100);
PrintArray(array);
Console.Write("\nВведите строку и столбец элемента: ");
input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"{PickElement(array, input[0], input[1])}");
