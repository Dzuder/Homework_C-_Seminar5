using static System.Console;
Clear();
// Напишите программу реализующую методы формирования массива,
// заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.[3,3 7,1 22,5 2,2 78,2] -> 76


    //-------------------------------ВОПРОС!!!------------------------------------------------------//
   //rand.NextDouble()*((100)-(-99))+(-99) как в это выражение встроить в метод Math.Round(?       //
  // или как просто указать сколько нужно цифр после запятой?                                     //
 //______________________________________________________________________________________________//


Random rand = new Random();
double[] array = new double[rand.Next(3, 15)];
double numbMax = array[0]; // у меня массив рандомный и с отрицательными числами, поэтому к 0 не приравнивал.
double numbMin = array[0]; // мое решение приравнять к array[0] в сочетании с тем что в методе DiffMaxmin верное? там получается 
                           // вначале array[0] c самим собой сравнивается.

RandomArray(array);
PrintArray(array);
WriteLine();
WriteLine();
DiffMaxmin(array, numbMax, numbMin);






void RandomArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.NextDouble() * ((100) - (-99)) + (-99);
        
    }
}





void PrintArray(double[] arr)
{
    Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"({Math.Round(arr[i], 1)}) ");
    }
    Write($"({Math.Round(arr[arr.Length -1], 1)}) ]");
}





void DiffMaxmin(double[] arr, double max,double min )
{

    for(int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
    }
    for(int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i]) min = arr[i];
    }
    Write($"Максимальное значение: ({Math.Round(max, 1)}),минимальное значение: ({Math.Round(min, 1)}).\n Разниц между максимальным и минимальным: ({Math.Round((max - min), 1)}).");
}