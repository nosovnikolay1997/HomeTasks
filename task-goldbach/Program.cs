Console.Clear();
int n = 998;
int[] primes = new int[n];
int number_of_primes = 0;
for (int i = 2; i < n; i++)
{
	bool is_prime = true;
	for (int j = 0; j < number_of_primes; j++)
		if (i % primes[j] == 0)
		{
			is_prime = false;
			break;
		}
	if (is_prime)
	{
		primes[number_of_primes] = i;
		number_of_primes++;
	}
}
Console.Write("Введите чётное число от 4 до 998: ");
int inp = Convert.ToInt32(Console.ReadLine());
while (inp < 4 || inp > 998 || inp % 2 != 0)
{
	Console.Write("Ошибка!\nВведите чётное число от 4 до 998: ");
	inp = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < number_of_primes; i++)
	for (int j = 0; j < number_of_primes; j++)
		if (primes[i] + primes[j] == inp)
		{
			Console.WriteLine($"{primes[i]} {primes[j]}");
			return;
		}
