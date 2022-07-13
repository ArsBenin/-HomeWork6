/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

double GetNumber(string message)
{
    double result = 0;
    string errorMessage = "Вы ввели не корректое число. Введите натуральное число";

    while(true)
    {
        
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void Intersection (double b1, double k1, double b2, double k2)

{  
    if(k1==k2 && b1==b2)
    {
        Console.WriteLine ($"Прямые совпадают");
    }
    else if (k1==k2 && b1!=b2)
    {
        Console.WriteLine ($"Прямые параллельные");
    }
    else
    {
    double x = (b1-b2)/(k2-k1);
    double y = k1*x + b1;
    Console.WriteLine ($"точка пересечения 2х указанных прямых ({x},{y})");
    }
}

double b1 = GetNumber("Введите значение b1");
double k1 = GetNumber("Введите значение k1");
double b2 = GetNumber("Введите значение b2");
double k2 = GetNumber("Введите значение k2");

Intersection(b1,k1,b2,k2);
