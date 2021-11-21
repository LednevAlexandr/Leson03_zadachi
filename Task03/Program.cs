// По заданному номеру дня недели вывести его название


Console.Write("Введите номер дня недели : ");
string a=Console.ReadLine();

switch (a)
{
    case "1" :
    Console.WriteLine("Понедельник");
    break;
     case "2" :
    Console.WriteLine("Вторник");
    break;
     case "3" :
    Console.WriteLine("Среда");
    break;
       case "4" :
    Console.WriteLine("четверг");
    break;

        default:
        Console.WriteLine("ерор");
        break;
}