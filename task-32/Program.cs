void InputArray(int[] array)
{
	Random rand = new Random();
	for (int i = 0; i < array.Length; i++)
		array[i] = rand.Next(-9, 10);
}

void PrintArray(int[] array)
{
	Console.WriteLine($"[{String.Join(", ", array)}]");
}

void FlipArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] *= -1;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
FlipArray(array);
PrintArray(array);
