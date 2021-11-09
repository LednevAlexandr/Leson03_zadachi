// В файле содержится последовательность из 10 000 целых
 //положительных чисел. Каждое число не превышает 10 000. 
 //Определите и запишите в ответе сначала количество пар 
 //элементов последовательности, у которых разность элементов
  //кратна 60, затем максимальную из разностей элементов таких пар. 
  //В данной задаче под парой подразумевается два различных элемента
   //последовательности. Порядок элементов в паре не важен.

   string[] input = System.IO.File.ReadLines(gvggggg)
   

   void Randoms(int[] arr, int min,int max)
{
    for(int i=0; i < arr.Length;i++)
    {
        arr[i] = new Random().Next(min,max);
    }
}


int[] array = new int[9999];

int multiplicity(int[] arr)
{
    int summ=0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
             if ((array[i]-array[i+1])%60==0)  summ=summ+1;
        }
       
    }
    return summ;
}

Randoms(array,0,10001);
multiplicity(array);
