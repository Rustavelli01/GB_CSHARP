 Console.Write("введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10;
    int thirdDigit = number % 10;
   // Math.Pow(5,2) => 5 в 2 степени => 25
   int result = (int)Math.Pow(secondDigit, thirdDigit);
   Console.WriteLine($"Число{number}: {secondDigit}^{thirdDigit} = {result}");
}
else
{
    Console.WriteLine("Число не 3-х значное");
}   