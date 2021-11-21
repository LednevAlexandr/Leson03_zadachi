﻿// Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [210 235; 210 300], 
//числа, имеющие ровно четыре различных натуральных делителя, не считая единицы и самого числа. Для каждого
 //найденного числа запишите эти четыре делителя в четыре соседних столбца на экране с новой строки. Делители 
 //в строке должны следовать в порядке возрастания.
//Например, в диапазоне [10; 16] ровно четыре различных натуральных делителя имеет число 12,
 //поэтому для этого диапазона вывод на экране должна содержать следующие значения: 2 3 4 
 

 List<int> CountDiv(int n)
 {
     List<int> list=new List<int>();

     for (int i = 2; i < n; i++)
     {
         if (n%i==0)
           {
               list.Add(i);
           }
     }
     return list;
 }
 
  List<int> list;
 for (int i =210235 ; i <= 210300; i++)
 {
     list=CountDiv(i);
     if(list.Count==4)
     {
      Console.Write(i+": ");
      for (int j = 0; j < list.Count; j++)
      {
          Console.Write(list[j]+" ");
      }
      Console.WriteLine();
     }
 }