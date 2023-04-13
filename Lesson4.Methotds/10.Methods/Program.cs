//Metoddan düzgün çoxlu qaytarma nümunəsi.
//Aşağıdakı metoddakı switch konstruksiyası vasitəsilə uyğun şərtə düşdükdə nəticəni return vasitəsilə geriyə qaytarırıq. 
string Compare(string user)
{
    switch (user)
    {
        case "Farid":
            return "Hello, Farid";
        case "Ferid":
            return "Hello, Ferid";
        default:
            return "You are not in the system.";
    }
}

string result = Compare("Farid");

Console.WriteLine(result);