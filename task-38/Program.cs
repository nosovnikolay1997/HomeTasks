void InputArray(double[] array, int from, int to)
{
	Random rand = new Random();
	for (int i = 0; i < array.Length; i++)
		array[i] = ((double)rand.Next(from*100, to*100))/100.0;
}

void PrintArray(double[] array)
{
	Console.WriteLine($"[{String.Join(", ", array)}]");
}

double ReleaseArray(double[] array)
{
	double min = array[0];
	double max = array[0];
	foreach (double element in array)
	{
		if (element < min)
			min = element;
		if (element > max)
			max = element;
	}
	return max-min;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array, 0, 100);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом: {ReleaseArray(array)}");
