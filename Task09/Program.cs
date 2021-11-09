//  9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = a%10;
Console.WriteLine($"Последняя цифра трехзначного числа: {s}");