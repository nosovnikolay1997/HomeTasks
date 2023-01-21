Console.Clear();
Console.Write("Введите количество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество ягод на каждом кусте на отдельных строках:");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
int prevprev = first;
int prev = second;
int current;
int total;
int max = -1;
for (int i = 2; i < n; i++)
{
	current = Convert.ToInt32(Console.ReadLine());
	total = prevprev + prev + current;
	if (total > max)
		max = total;
	prevprev = prev;
	prev = current;
}
/*
Separately go through the cases
with the one before the last, last and first;
and with the last, first and second
*/
total = prevprev + prev + first;
if (total > max)
	max = total;
total = prev + first + second;
if (total > max)
	max = total;
Console.WriteLine($"Max = {max}");
