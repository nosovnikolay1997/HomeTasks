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

int[] ReleaseArray(int[] array)
{
	int[] result = new int[(array.Length + 1)/2];
	for (int i = 0; i < (array.Length + 1)/ 2; i++)
		result[i] = array[i] * array[array.Length - 1 - i];
	return result;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, -10, 11);
PrintArray(array);
PrintArray(ReleaseArray(array));
