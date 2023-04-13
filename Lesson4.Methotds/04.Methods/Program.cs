//Aşağıdakı sətirdə Function adlı metod yaradırıq.
//Bu metod heç bir arqument qəbul etmir və string tipli dəyişən nəticə qayarmır.
//6-cı sətirdə metodun bədənində Hello! yazısını ekrana çıxarırıq.
string Function()
{
    return "Hello!";
}

//Aşağıdakı sətirdə @string adında lokal dəyişən yaradırıq və ona Function metodunun qaytardığı dəyəri mənimsədirik.
string @string = Function();

Console.WriteLine(@string);

//və ya
Console.WriteLine(Function());