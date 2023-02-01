HashSet<string> permutations(string input)
{
	HashSet<string> output = new HashSet<string>();
	if (input.Length == 1)
		output.Add(input);
	for (int i = 0; i < input.Length; i++)
	{
		string substring = string.Empty;
		for (int j = 0; j < input.Length; j++)
			if (i != j)
				substring += input[j];
		foreach (string child_permutation in permutations(substring))
			output.Add(input[i] + child_permutation);
	}
	return output;
}

Console.Clear();
Console.Write("Введите строку: ");
string input = Console.ReadLine();
Console.WriteLine("Все возможные перестановки:");
foreach (string res in permutations(input))
	Console.WriteLine(res);
