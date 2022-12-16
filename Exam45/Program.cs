/*Напишите программу, которая будет
создавать копию заданного массива с помощью
поэлементного копирования.*/

int[] PrintArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 15);
        System.Console.Write(" " + array[i] + " ");
    }
    return array;
}

int[] copyArray(int[] array)
{
    int[] copArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copArray[i] = array[i];
        System.Console.Write(" "+copArray[i]+" ");
    }
    return copArray;
}

int[] array = PrintArray(6);
System.Console.WriteLine();
int[] copArray=copyArray(array);


