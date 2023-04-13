//Aşağıdakı nümunədə normal variantı qoruyub-saxlamaq üçün əvvəlcədən yoxlanış edilir.
string Function(string name)
{
    if (name == "fool")
    {
        return "Siz yolverilmez addan istifade etmisiniz.";
    }

    string sentence = "Hello " + name + "!";

    return sentence;
}

string sentence = Function("fool");

Console.WriteLine(sentence);