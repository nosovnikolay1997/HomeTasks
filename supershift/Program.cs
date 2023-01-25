Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] in_array = new int[n];
Console.WriteLine($"Введите {in_array.Length} чисел, каждое с новой строки:");
for (int i = 0; i < in_array.Length; i++)
	in_array[i] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сдвиг: ");
int k = Convert.ToInt32(Console.ReadLine()) % in_array.Length + in_array.Length;
int[] out_array = new int[in_array.Length];
for (int i = 0; i < in_array.Length; i++)
	out_array[(i + k) % in_array.Length] = in_array[i];
Console.WriteLine($"{String.Join(" ", out_array)}");
