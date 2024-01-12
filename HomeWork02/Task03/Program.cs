// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());

int firstNum = number / 10;
int secondNum = number % 10;

if (number > 10 && number < 99)
{

    if (firstNum > secondNum)
    {
        Console.WriteLine("=>" + firstNum);
    }
    else
    {
        Console.WriteLine("=>" + secondNum);
    }
}
else
{
    Console.WriteLine("Ваше число не входит в отрезок от 10 до 99");
}