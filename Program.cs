// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
/*Console.WriteLine("Введите количество чисел M: ");
int M = int.Parse(Console.ReadLine()!);
int[] array = GetArray(M, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}] -> Количество чисел больше 0 = {Coun()}");

int Coun()
{
    int count = 0;
 for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    count++;
}
return count;
}



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x+b1, y = k2*x+b2; значения b1,k1,b2 и k2 задаются пользователем.

/*Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых ({x}, {y})");*/