// Показать натуральные числа от N до 1, N задано


int Method(int N)
{
    if(N==1) return 1;
    else Console.WriteLine(N);
    return Method(N-1);
}

Console.WriteLine(Method(5));