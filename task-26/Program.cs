Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 0; n != 0; i++)
	n = n / 10;
Console.WriteLine($"Количество цифр: {i}");
