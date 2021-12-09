// Найти сумму элементов от M до N, N и M заданы

int Summ(int M,int N)
{
    if (N==M) return N;
   else return N+Summ(M,N-1);  
}

Console.WriteLine(Summ(-2,3));

