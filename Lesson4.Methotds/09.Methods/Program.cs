//Metoddan düzgün çoxlu qaytarma nümunəsi.
//return sözü metodun işini dayandır və ondan sonrakı kodun icrasına imkan vermir.
string Compare(int value1, int value2)
{
    if (value1 < value2)
    {
        return "Comparison Less Then";
    }
    else if (value1 > value2)
    {
        return "Comparison Greater Then";
    }

    return "Comparison Equal";
}

int operand1 = 1, operand2 = 2;

string result = Compare(operand1, operand2);

Console.WriteLine(result);