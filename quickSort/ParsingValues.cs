using System;
using System.Collections.Generic;
using System.Text;

public static class Parse
{
    public static int IntValue(string text)
    {
        string input = Console.ReadLine();
        int value;
        while (!int.TryParse(input, out value))
        {
            Console.Write($"Please, input correct {text}: ");
            input = Console.ReadLine();
        }
        return value;
    } //функция для парсинга int с выводом названия значения
    public static int IntValue()
    {
        string input = Console.ReadLine();
        int value;
        while (!int.TryParse(input, out value))
        {
            Console.Write("Please, input correct value: ");
            input = Console.ReadLine();
        }
        return value;
    } //функция для парсинга int без вывода названия значения
    public static double DoubleValue(string text)
    {
        string input = Console.ReadLine();
        double value;
        while (!double.TryParse(input, out value))
        {
            Console.Write($"Please, input correct {text}: ");
            input = Console.ReadLine();
        }
        return value;
    } //функция для парсинга double с выводом названия значения
    public static double DoubleValue()
    {
        string input = Console.ReadLine();
        double value;
        while (!double.TryParse(input, out value))
        {
            Console.Write("Please, input correct value: ");
            input = Console.ReadLine();
        }
        return value;
    } //функция для парсинга double без вывода названия значения

}
