int n = new Random().Next(10,100);
Console.WriteLine(n);
int a = n / 10;
int b = n % 10;
if (a > b)
	Console.WriteLine(a);
else
	Console.WriteLine(b);
