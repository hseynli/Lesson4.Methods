void DoWork(int number)
{
	for (int i = 0; i <= number; i++)
		Console.Write(i);
    Console.WriteLine();
}

for (int i = 0; i < 100; i++)
	DoWork(new Random().Next(0, 11));