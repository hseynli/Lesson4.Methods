string Function()
{
    //Aşağıda Function metoduna aid olan word adlı dəyişən yaradırıq və ona Hello! dəyərini mənimsədirik.
    //Daha sonra həmin dəyişənin dəyərini geriyə qaytarırıq.
    string word = "Hello!";

    return word;
}

string word = Function();

Console.WriteLine(word);