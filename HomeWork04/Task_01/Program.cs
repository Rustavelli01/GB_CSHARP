// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// рограмма завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true) // true == true
{
    Console.WriteLine("Введите число:");
    Console.Write("!q! для выхода из программы: ");
    string EnterNumber = Console.ReadLine();
    if (EnterNumber == "q")
    {
        Console.WriteLine("[STOP]");
        break;
    }
    int number;
    if (int.TryParse(EnterNumber, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            
            break;
        }
        else
        {
            Console.WriteLine("[STOP]");
            Console.WriteLine("Некорректный ввод. ");
            Console.WriteLine("введите целое число или 'q'.");
        }

      
    }
    Console.WriteLine(number);
    
}