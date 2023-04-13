//ref, out və in açar sözləri ilə göndərilən dəyişənlərin kopyası yox, özü göndərilir
int Method(ref int a)
{
    int b = a * 2;
    a = 5;
    return b;
}

int operand = 2;

int result = Method(ref operand);

Console.WriteLine("{0}; {1};", operand, result);