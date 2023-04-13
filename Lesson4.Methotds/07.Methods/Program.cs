//Aşağıdakı sətirdə Add adlı metod yaradırıq.
//Bu metod iki int tipli arqument qəbul edir və geriyə int tipində dəyər qaytarır.
int Add(int summand1, int summand2)
{
    return summand1 + summand2;
}

//Aşağıda summand1 dəyişəninə mənimsədilən dəyərin yazılışına DİQQƏT!
int summand1 = 10_000, summand2 = 3;

int sum = Add(summand1, summand2);

Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);