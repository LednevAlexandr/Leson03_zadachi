// Написать программу возведения числа А в целую стень B

int Method(int A, int B)
{
    if(B==0) return 1;
    else return A*Method(B-1);
}

Console.WriteLine(Method(2,3));