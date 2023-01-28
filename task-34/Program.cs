void InputArray(int[] array, int from, int to)
{
	Random rand = new Random();
	for (int i = 0; i < array.Length; i++)
		array[i] = rand.Next(from, to);
}

void PrintArray(int[] array)
{
	Console.WriteLine($"[{String.Join(", ", array)}]");
}

int ReleaseArray(int[] array)
{
	int result = 0;
	foreach (int element in array)
		if (element % 2 == 0)
			result++;
	return result;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 100, 1000);
PrintArray(array);
Console.WriteLine($"Количество чётных элементов: {ReleaseArray(array)}");
