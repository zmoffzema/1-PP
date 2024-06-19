using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Конвертер температуры");
        Console.WriteLine("Выберите режим:");
        Console.WriteLine("1. Цельсий в Фаренгейт");
        Console.WriteLine("2. Фаренгейт в Цельсий");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ConvertCelsiusToFahrenheit();
                break;
            case 2:
                ConvertFahrenheitToCelsius();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Введите температуру в Цельсиях: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Температура в Фаренгейтах: " + fahrenheit);
    }

    static void ConvertFahrenheitToCelsius()
    {
        Console.Write("Введите температуру в Фаренгейтах: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Температура в Цельсиях: " + celsius);
    }
}
