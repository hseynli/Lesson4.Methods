int Method(out int a)
{
    // Daxil olan dəyişənlərin dəyəri mütləq dəyişdirilməlidir, əks halda XƏTA baş verəcəkdir.
    a = 2;
    return a * 2;
}

int operand;

// out - ilkin dəyərə mənimsədilməyən dəyişəni ötürməyə imkan verir.

int result = Method(out operand);

Console.WriteLine("{0}; {1};", operand, result);