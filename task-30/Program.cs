Console.Clear();
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
	array[i] = rand.Next(0, 2);
Console.WriteLine($"[{String.Join(", ", array)}]");
