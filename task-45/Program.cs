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

int[] MakeACopy(int[] array)
{
	int[] copy = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
		copy[i] = array[i];
	return copy;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, -100, 101);
Console.WriteLine("Оригинал:");
PrintArray(array);
Console.WriteLine("Копия:");
PrintArray(MakeACopy(array));
