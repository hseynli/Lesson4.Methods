void Add(ref int x, ref int y, int sum)
{
    sum = x + y;
}

Console.WriteLine("Birinci ededi daxil edin.");

string operand1 = Console.ReadLine()!;
int summand1 = Int32.Parse(operand1);

Console.WriteLine("Ikinci ededi daxil edin");

string operand2 = Console.ReadLine()!;
int summand2 = Int32.Parse(operand2);

int sum = 0;

Add(ref summand1, ref summand2, sum);

Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum); // Xəta.