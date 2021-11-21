// 27. Определить количество цифр в числе

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


int CountDigit(int n)
{
    int k=0;
    while(n!=0)
    {
        k++;
        n=n/10;
    }
    return k;
}
Console.WriteLine(CountDigit(a));
