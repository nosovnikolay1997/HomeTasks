double[] InputArray()
{
	double[] result = new double[3];
	for (int i = 0; i < result.Length; i++)
		result[i] = Convert.ToDouble(Console.ReadLine());
	return result;
}

bool IsTriangle(double[] array)
{
	if (array[0] > array[1] + array[2])
		return false;
	if (array[1] > array[0] + array[2])
		return false;
	if (array[2] > array[0] + array[1])
		return false;
	return true;
}

Console.Clear();
Console.WriteLine("Введите три положительных дробных числа, каждое с новой строки:");
double[] array = InputArray();
if (IsTriangle(array))
	Console.WriteLine("Такой треугольник существует.");
else
	Console.WriteLine("Такой треугольник не существует.");
