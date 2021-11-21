// 9. Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int s = Convert.ToInt32(Console.ReadLine());

int result = s%10;
Console.Write(result);