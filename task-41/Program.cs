Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {n} чисел, каждое с новой строки:");
int count;
for (count = 0; n > 0; n--)
	if (Convert.ToInt32(Console.ReadLine()) > 0)
		count++;
Console.WriteLine($"Чисел больше 0: {count}");
