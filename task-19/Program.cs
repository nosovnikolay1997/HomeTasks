Console.Write("Введите целое неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
	Console.Write("Ошибка!\nВведите целое неотрицательное число: ");
	n = Convert.ToInt32(Console.ReadLine());
}
int n_flipped = 0;
int m = n;
while (m > 0)
{
	n_flipped = n_flipped*10 + m%10;
	m = m / 10;
}
if (n_flipped == n)
	Console.WriteLine("Да.");
else
	Console.WriteLine("Нет.");
