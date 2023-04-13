// Parametr olaraq göndərilən arqument metod işini bitirdikdən sonra məhv olacaqdır.
void AddTwo(int a)
{
    a = a + 2;
    Console.WriteLine("int a = {0}", a);
}

Console.WriteLine("Eded daxil edin:");

// İstifadəçidən input qəbul edirik və onu int tipinə konvert edirik.

string number = Console.ReadLine()!;
int result = int.Parse(number);

Console.WriteLine("result = {0}", result);

// Arqument olaraq result dəyişənin özü yox, oun kopyası göndərilir.
AddTwo(result);
Console.WriteLine("result = {0}", result);
