//Metodu çağıran zaman ona göndərilən dəyişənin özü yox, onun kopyası göndərilir.
void Method(int parameter)
{
    parameter++;
    Console.WriteLine($"parameter = {parameter}");
}

int variable = 0;

Method(variable);

Console.WriteLine($"variable = {variable}");