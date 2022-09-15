/* Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементов массива.
[3 7 22 2 78] -> 76    */

Console.Clear();
Console.WriteLine("\n Задача 38");
Random rng = new Random();
double[] GetArray(int size, double minValue, double maxValue)
{
    var array = new double[size];
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue + (maxValue - minValue) * rng.NextDouble();
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    return array;
}
double[] array = GetArray(6, 0, 99);

double FindTheDelta(double delta = 0)
{
    double min = 100;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
        delta = max - min;
    }
    return delta;
}
Console.Write($" -> {FindTheDelta()}");
