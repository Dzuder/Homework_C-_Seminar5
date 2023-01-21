using static System.Console;
Clear();
int[] array = new int[new Random().Next(12, 25)];

RandomArray(array);
PrintArray(array);
SumEven(array);



void RandomArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while(index < length)
{
    collection[index] = new Random().Next(100, 999);
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
void SumEven(int[] arr)
{
    int pos = 0;
    int sum = 0;
    int len = arr.Length;
    while(pos < len)
{
    if((arr[pos]) % 2 == 0)
    {
        sum = sum + 1;
    } 
   
    pos++;
   
        
    
  
}
WriteLine("Number of even numbers in array: " + sum);
}