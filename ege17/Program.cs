// В файле содержится последовательность из 10 000 целых
 //положительных чисел. Каждое число не превышает 10 000. 
 //Определите и запишите в ответе сначала количество пар 
 //элементов последовательности, у которых разность элементов
  //кратна 60, затем максимальную из разностей элементов таких пар. 
  //В данной задаче под парой подразумевается два различных элемента
 //последовательности. Порядок элементов в паре не важен.

  string[] input = System.IO.File.ReadAllLines("17 (2).txt");
  int[] a = new int[10000];
   for(int i=0;i<input.Length;i++)
   {
       a[i] = Convert.ToInt32(input[i]);
   }


int multiplicity(int[] arr, out int max)
{
    int count=0;
    max=0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
             if ((arr[i]-arr[j])%60==0) {
              count=count+1;
              if((Math.Abs(arr[i]-arr[j]))>max) {
              max = Math.Abs(arr[i]-arr[j]);
              }    
             }
        }
       
    }
    return count;
}
int max;
int c = multiplicity(a,out max);
Console.WriteLine(c+"  "+max);

