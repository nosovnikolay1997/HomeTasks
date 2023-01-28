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
	for (int i = 1; i < array.Length; i += 2)
		result += array[i];
	return result;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array, -100, 101);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {ReleaseArray(array)}");
