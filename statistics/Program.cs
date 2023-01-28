void InputArray(int[] array, int from, int to)
{
	Console.WriteLine($"Введите {array.Length} чисел от {from} до {to} включительно, каждое на новой строке:");
	for (int i = 0; i < array.Length; i++)
	{
		int current = Convert.ToInt32(Console.ReadLine());
		while (current < from || current > to)
		{
			Console.WriteLine($"Ошибка!\nВведите число от {from} до {to} включительно:");
			current = Convert.ToInt32(Console.ReadLine());
		}
		array[i] = current;
	}
}

void PrintArray(int[] array)
{
	Console.WriteLine($"{String.Join(" ", array)}");
}

int[] ReleaseArray(int[] array, int remainder)
{
	int[] result = new int[array.Length];
	int result_size = 0;
	foreach (int element in array)
		if (element % 2 == remainder)
		{
			result[result_size] = element;
			result_size++;
		}
	Array.Resize(ref result, result_size);
	return result;
}

Console.Clear();
Console.Write("Введите положительное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
	Console.Write("Ошибка!\nВведите положительное целое число: ");
	n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];
InputArray(array, 1, 31);
int[] odd_array = ReleaseArray(array, 1);
PrintArray(odd_array);
int[] even_array = ReleaseArray(array, 0);
PrintArray(even_array);
if (odd_array.Length > even_array.Length)
	Console.WriteLine("NO");
else
	Console.WriteLine("YES");
