/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/* y=5x+2
*  y=9x+4
*  5x+2=9x+4
*  5x-9x=4-2
*  x(5-9)=4-2/(5-9)
* Ax+By+C=0
* Ax+By+C=0
* 
*
*
*
*/

void twoLines()
{
    System.Console.Write("Введите значение переменной b1: ");
    double b1=double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите значение переменной k1: ");
    double k1=double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите значение переменной b2: ");
    double b2=double.Parse(Console.ReadLine()!);
    System.Console.Write("Введите значение переменной k2: ");
    double k2=double.Parse(Console.ReadLine()!);

    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    
    System.Console.WriteLine(" "+x+"; "+y);
}
twoLines();