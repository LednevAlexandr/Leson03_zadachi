//Написать программу вычисления функции Аккермана

int a(int m,int n)
{
    if(m==0) return n+1;
    else if(m>0 && n==0) return a(m-1,1);
    else if(m>0 && n>0) return a(m-1,a(m,n-1));
    else return a(m,n);
}
Console.WriteLine(a(1,1));