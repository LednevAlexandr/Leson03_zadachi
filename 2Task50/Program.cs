ulong F(ulong n){
    if (n==0) return 1;
    else return F(n-1)*n;
}

ulong Fu(ulong n)
{
    if(n==0) return 0;
    if(n==1 || n==2) return 1;
    else return Fu(n-1)+Fu(n-2);
}

Console.WriteLine(Fu(6));

Console.Write();
int a = Convert.ToInt32(Console.ReadLine())