﻿// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

void PrinrRandomArray(int[] arr, int min, int max) 
{
      for(int i =0;i<arr.Length;i++)
      {
          arr[i]=new Random().Next(min,max);
          Console.WriteLine(arr[i]);
      }
}

int[] array = new int[8];
PrinrRandomArray(array,0,2);