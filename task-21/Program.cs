Console.Clear();
Console.WriteLine("Введите X(A): ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y(A): ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z(A): ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X(B): ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y(B): ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z(B): ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками: {Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)),2)}");
