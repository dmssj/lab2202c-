using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("номер задачи:");
        Console.WriteLine("1 - возведение числа в степень");
        Console.WriteLine("2 - преобразование числа");
        Console.Write("введите 1 или 2: ");
        
        int selection = int.Parse(Console.ReadLine());

        if (selection == 1)
        {
            elevate();
        }
        else if (selection == 2)
        {
            convert_number();
        }
    }

    static void elevate()
    {
        Console.Write("число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("степень: ");
        int degree = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }

        Console.WriteLine($"результат: {result}");
    }