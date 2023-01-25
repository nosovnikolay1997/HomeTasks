Console.Clear();
Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 0; i < b; i++)
	res = res * a;
Console.WriteLine($"{a}^{b} = {res}");
