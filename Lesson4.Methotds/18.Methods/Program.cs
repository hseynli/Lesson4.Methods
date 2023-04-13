//in ilə göndərilən dəyişənlərin dəyərini metodun daxilində dəyişmək olmaz!
void Method(in int parameter)
{
    //parameter++;
    Console.WriteLine($"parameter = {parameter}");
}

int variable = 0;

Method(in variable);

Console.WriteLine($"variable = {variable}");