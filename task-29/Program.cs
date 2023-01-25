Console.Clear();
int[] array = new int[8];
Console.WriteLine($"Введите {array.Length} чисел, каждое с новой строки:");
for (int i = 0; i < array.Length; i++)
	array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{String.Join(", ", array)}]");
