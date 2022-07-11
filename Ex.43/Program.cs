/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не корректое число. Введите натуральное число";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void Intersection (int b1, int k1, int b2, int k2)

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
    double y = k1 * x + b1;
    Console.WriteLine ($"точка пересечения 2х указанных прямых ({x},{y})");
    }
}

int b1 = GetNumber("Введите значение b1");
int k1 = GetNumber("Введите значение k1");
int b2 = GetNumber("Введите значение b2");
int k2 = GetNumber("Введите значение k2");

Intersection(b1,k1,b2,k2);