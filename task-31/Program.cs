void InputArray(int[] array)
{
	Random rand = new Random();
	for (int i = 0; i < array.Length; i++)
		array[i] = rand.Next(-9,10);

}

void ReleaseArray(int[] array)
{
	int sum_positive = 0;
	int sum_negative = 0;
	foreach (int element in array)
		if (element > 0)
			sum_positive += element;
		else
			sum_negative += element;
	Console.WriteLine($"Сумма положительных чисел: {sum_positive}\nСумма отрицательных чисел: {sum_negative}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
ReleaseArray(array);
