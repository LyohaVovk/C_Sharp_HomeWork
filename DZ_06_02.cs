// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение с использованием математики
double GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine()!);
}

double [] GetFuncData()
{
    double [] firstLineEq = new double[2];
    firstLineEq[0] = GetNumber("Введите значение коэффициента k линейного уравнения: ");
    firstLineEq[1] = GetNumber("Введите значение константы b линейного уравнения: ");
    return firstLineEq;
}

double [] GetCoordIntersection(double [] firstFunc, double [] secondFunc)
{
    double [] coordIntersection = new double[2];
    coordIntersection[0] = (secondFunc[1] - firstFunc[1]) / (firstFunc[0] - secondFunc[0]);
    coordIntersection[1] = coordIntersection[0] * firstFunc[0] + firstFunc[1];
    return coordIntersection;
}

int ParallelOrConcidence(double [] firstFunc, double [] secondFunc)
{
    if (firstFunc[0] == secondFunc[0])
    {
        if (firstFunc[1] == secondFunc[1])
            return 2;
        else
            return 1;  
    }
    return 0;
}

Console.Write("Введите значения для первой функции: ");
double [] firstFunc = GetFuncData();
Console.Write("Введите значения для второй функции: ");
double [] secondFunc = GetFuncData();
int relPosition = ParallelOrConcidence(firstFunc, secondFunc);
if (relPosition == 2)
    Console.WriteLine("Гафики функций совпадают.");
else if (relPosition == 1)
    Console.WriteLine("Гафики функций параллельны.");
else
{
    double [] crossCoord = GetCoordIntersection(firstFunc, secondFunc);
    Console.WriteLine($"Для заданных k1 = {firstFunc[0]}, b1 = {firstFunc[1]}, k2 = {secondFunc[0]}, b2 = {secondFunc[1]}, координаты пересечения функций равны => ({crossCoord[0]}, {crossCoord[1]})");
}
    

