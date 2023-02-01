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

void FlipArray(int[] array)
{
	for (int i = 0; i < array.Length / 2; i++)
	{
		int buf = array[i];
		array[i] = array[array.Length - 1 - i];
		array[array.Length - 1 - i] = buf;
	}
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, 0, 100);
PrintArray(array);
FlipArray(array);
PrintArray(array);
