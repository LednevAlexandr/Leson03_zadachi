// 10. Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int s = Convert.ToInt32(Console.ReadLine());

int result = s%100;
result = result/10;

Console.Write(result);
