void AddTwo(ref int a)
{
    a = a + 2;
    Console.WriteLine("int a = {0}", a);
}

Console.WriteLine("Eded daxil edin:");

// İstifadəçidən input qəbul edirik və onu int tipinə konvert edirik.

string number = Console.ReadLine()!;
int result = Int32.Parse(number);

Console.WriteLine("result = {0}", result);

// Arqument olaraq result dəyişənin kopyası yox, özü göndərilir
AddTwo(ref result);
Console.WriteLine("result = {0}", result);