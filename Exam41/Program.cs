/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] nums()
{
    System.Console.Write("Сколько чисел вы хотите задать? ");
    int countNumbers = int.Parse(Console.ReadLine()!);

    int[] array = new int[countNumbers];

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Пользователь, введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}



int countPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        System.Console.Write(" " + array[i] + " ");
    }
    System.Console.WriteLine("Количество чисел больше 0: " + count);
    return count;
}
int [] array=nums();
countPositiveNumbers(array);