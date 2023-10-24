// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2


int N=10;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(1,100);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int count=0;
for(var i=0; i<a.Length;i++)
{
if(i>20 && i<90)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);