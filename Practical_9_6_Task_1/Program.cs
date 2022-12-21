using System;
using System.IO;

namespace Practical_9_6_Task_1
{
    internal class Program
    {
        class MyException: Exception
        {            
            public MyException(string message) : base(message) { }
        }

        static void Main()
        {            
            Exception[] exceptions = 
            { 
                new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым."),
                new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю."),
                new RankException("В метод передается массив с неправильным числом измерений."),
                new FileNotFoundException("Файл не существует."),
                new MyException("Мое исключение...")
            };             
            
                foreach (var exception in exceptions)
                {
                    try
                    {
                        throw exception;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
            

            Console.ReadKey();
        }
    }
}
