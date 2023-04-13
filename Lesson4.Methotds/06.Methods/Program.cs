//Aşağıdakı sətirdə Function adlı metod yaradırıq.
//Bu metod bir string tipli arqument qəbul edir və geriyə string tipində dəyər qaytarır.
string Function(string name)
{
    string sentence = "Hello " + name + "!";

    return sentence;
}

string sentence = Function("Alex");

Console.WriteLine(sentence);