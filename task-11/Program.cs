int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {n}");
int a = n / 100;
int b = n % 10;
Console.WriteLine(a * 10 + b);
