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

bool isInArray(int n, int[] array)
{
	foreach (int element in array)
		if (element == n)
			return true;
	return false;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
if (isInArray(k, array))
	Console.WriteLine("Да");
else
	Console.WriteLine("Нет");
