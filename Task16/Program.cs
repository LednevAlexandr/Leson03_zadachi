// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a==6 | a==7) Console.WriteLine("Выходной");
else
{
    Console.WriteLine("Будни");
}