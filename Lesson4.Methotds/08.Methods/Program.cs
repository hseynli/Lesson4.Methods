// Məntiqi (boolean) tipində dəyər geriyə qaytaran metodlara metod-predikat deyilir.
bool And(bool a, bool b)
{
    return a && b;
}

bool operand1 = true, operand2 = true;

bool result = And(operand1, operand2);

Console.WriteLine("{0} && {1} = {2}", operand1, operand2, result);