using static System.Console;
Clear();
//Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
//
// ЗАМЕТИЛ, ЧТО ЕСЛИ В КОНСОЛЬ НЕ УМЕЩАЕТСЯ ВЫВОД БЕЗ ПРОЛИСТЫВАНИЯ, ТО ПРОГРАММА ВЫДАЕТ НЕ ВЕРНЫЙ ОТВЕТ. НО СТОИТ УВЕЛИЧИТЬ КОНСОЛЬ И ВСЕ ОК.
 //ЧТО НЕ ТАК?


int[] array = new int[new Random().Next(2, 10)];

RandomArray(array);
PrintArray(array);
SumOddNumber(array);


void RandomArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while(index < length)
{
    collection[index] = new Random().Next(1, 100);
    index++;
}
}


void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while(position < count)
{
    WriteLine(col[position]);
    position++;
}

}

void SumOddNumber(int[] arr)
{
    int pos = 1;
    int len = arr.Length;
    int sum = 0;
    while(pos < len)
    {
        sum = sum + arr[pos];
        pos = pos + 2;


    }

WriteLine("Number of odd numbers in array: " + sum);
}