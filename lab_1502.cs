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
    
    static void convert_number()
    {
        Console.Write("введите число >=100: ");
        int original_number = int.Parse(Console.ReadLine());

        string number_string = original_number.ToString();

        char second_digit = number_string[1];

        string new_string = number_string.Remove(1, 1);

        string result_line = new_string + second_digit;

        int result_number = int.Parse(result_line);

        Console.WriteLine($"новое число: {result_number}");
    }
}
