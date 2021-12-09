// Показать натуральные числа от 1 до N, N задано

int PrintNumber(int N)
{
    if(N==1) return N;
    else System.Console.WriteLine(N);
    return PrintNumber(N-1);

}
Console.Write(PrintNumber(5));
