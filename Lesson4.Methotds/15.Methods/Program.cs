int Method(out int a)
{
    // Daxil olan dəyişənlərin dəyəri mütləq dəyişdirilməlidir, əks halda XƏTA baş verəcəkdir.
    a = 2;
    return a * 2;
}

// out - bizə metodu çağıran zaman dəyişənin yaradılmasına imkan verir.

int result = Method(out int operand);

Console.WriteLine("{0}; {1};", operand, result);