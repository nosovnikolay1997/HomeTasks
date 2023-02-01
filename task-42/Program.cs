int[] ToBinary(int x)
{
	//65 should be enough to store 64 bit number
	int n = 65;
	int[] binary = new int[n];
	for (int i = binary.Length - 1; x > 0; i--)
	{
		binary[i] = x % 2;
		x = x / 2;
	}
	return binary;
}

void PrintBinary(int[] binary)
{
	//Remove leading zeroes
	int start;
	for (start = 0; start < binary.Length - 1; start++)
		if (binary[start] == 1)
			break;
	for (int i = start; i < binary.Length; i++)
		Console.Write($"{binary[i]}");
	Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
PrintBinary(ToBinary(a));
