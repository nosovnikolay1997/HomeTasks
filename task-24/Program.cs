Console.Clear();
Console.Write("Введите положительное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {n} = {((1+n)*n)/2}");
