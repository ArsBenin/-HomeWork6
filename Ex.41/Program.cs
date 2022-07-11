/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetAmount()
{
    int result = 0;
    Console.WriteLine("Введите колличество чисел");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
            else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не корректное число. Введите корректное число");
        }
    }

    return result;
}

double GetNumber()
{
    double result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
            else
        {
            Console.WriteLine("Вы ввели не число. Введите число");
        }
    }

    return result;
}

double [] Number(int number)
{
double[] arr = new double[number];
for(int i=0; i < arr.Length; i++)
{  
   arr[i]= GetNumber();
}
return arr;
}


void PrintNumbers(double [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}

void Ammount (double [] arr)
{
    int result = 0;
for(int i=0; i < arr.Length; i++)
{  
   if(arr[i]>0) result++;
}
if(result==2 || result==3 || result == 4)
    {
        Console.WriteLine($"{result} числa больше 0 введено пользователем");
    }
    else
    {
        Console.WriteLine($"{result} чисел больше 0 введено пользователем");
    }
    return;
}

int ammount = GetAmount();
double [] numbers = Number(ammount);
Console.WriteLine();
PrintNumbers(numbers);
Console.WriteLine();
Ammount(numbers);