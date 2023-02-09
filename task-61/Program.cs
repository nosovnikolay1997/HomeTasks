int[][] CalculatePascalTriangle(int n)
{
	int[][] res = new int[n][];
	res[0] = new int[1];
	res[0][0] = 1;
	for (int i = 1; i < res.Length; i++)
	{
		res[i] = new int[i+1];
		res[i][0] = 1;
		res[i][i] = 1;
		for (int j = 1; j < res[i].Length - 1; j++)
			res[i][j] = res[i - 1][j - 1] + res[i - 1][j];
	}
	return res;
}

// If we put only a single space between numbers
// then the sides of the triangle will end up 
// being concave. To fix this, we need to put
// extra spaces inbetween the numbers in the
// middle lines.
string[] PascalToStrings(int[][] pascal)
{
	string[] res = new string[pascal.Length];
	// We need to determine the width of the last line
	res[res.Length - 1] = $"{pascal[pascal.Length - 1][0]}";
	for (int i = 1; i < pascal[pascal.Length - 1].Length; i++)
		res[res.Length - 1] += $" {pascal[pascal.Length - 1][i]}";
	// We need to handle first line separately
	// Otherwise there is goind to be division
	// by zero later
	res[0] = $"{pascal[0][0]}".PadLeft((1 + res[res.Length - 1].Length) / 2);
	for (int i = 1; i < res.Length - 1; i++)
	{
		// workStr is used to determine how much spaces we need
		string workStr = string.Empty;
		for (int j = 0; j < pascal[i].Length; j++)
			workStr += $"{pascal[i][j]}";
		int neededWidth = 1 + ((res[res.Length - 1].Length - 1) * i) / (res.Length - 1);
		int amountOfSpaces = neededWidth - workStr.Length;
		int smallSpaceWidth = amountOfSpaces / (pascal[i].Length - 1);
		int amountOfBigSpaces = amountOfSpaces % (pascal[i].Length - 1);
		res[i] = $"{pascal[i][0]}";
		for (int j = 1; j < pascal[i].Length; j++)
		{
			if (amountOfBigSpaces > 0)
			{
				res[i] += ' ';
				amountOfBigSpaces--;
			}
			for (int k = 0; k < smallSpaceWidth; k++)
				res[i] += ' ';
			res[i] += $"{pascal[i][j]}";
		}
		res[i] = res[i].PadLeft((res[i].Length + res[res.Length - 1].Length) / 2);
	}
	return res;
}

void PrintArrayOfStrings(string[] inp)
{
	for (int i = 0; i < inp.Length; i++)
		Console.WriteLine(inp[i]);
}

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
	Console.Write("Ошибка!\nВведите количество строк треугольника Паскаля: ");
	n = Convert.ToInt32(Console.ReadLine());
}
PrintArrayOfStrings(PascalToStrings(CalculatePascalTriangle(n)));
