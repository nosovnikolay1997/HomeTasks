void FillMatrix(int[,] matrix, int from, int to)
{
	Random rand = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i,j] = rand.Next(from, to);
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}

int[,] MultiplyMatrices(int[,] m1, int[,] m2)
{
	if (m1.GetLength(1) != m2.GetLength(0))
		return null;
	int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];
	for (int i = 0; i < res.GetLength(0); i++)
		for (int j = 0; j < res.GetLength(1); j++)
			for (int k = 0; k < m1.GetLength(1); k++)
				res[i, j] += m1[i, k] * m2[k, j];
	return res;
}

Console.Clear();
Console.Write("Введите 3 числа (количество строк первой матрицы, количество столбцов первой матрицы/количество строк второй матрицы и количество стобцов второй матрицы: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix0 = new int[input[0], input[1]];
int[,] matrix1 = new int[input[1], input[2]];
FillMatrix(matrix0, 0, 10);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix0);
FillMatrix(matrix1, 0, 10);
Console.WriteLine("\nВторая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("\nПроизведение матриц:");
PrintMatrix(MultiplyMatrices(matrix0, matrix1));
