Console.Write("введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    //Интерполяция: $ "Значение переменной{thirdDigit}={} "
    Console.WriteLine($"Результат от числа {number} = {result}");
}
else
{
    Console.WriteLine("Число не 3-х значное");
}