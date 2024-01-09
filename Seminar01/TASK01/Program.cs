// int number = 9;
// int result = number * number;



Console.Write("Введите первое число: ");
int firstNum  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum  = Convert.ToInt32(Console.ReadLine());

if (firstNum == secondNum * secondNum)
{
    Console.WriteLine("Да, " + firstNum + " является кв. от числа " + secondNum );
}
else 
{
    Console.WriteLine("Нет, " + firstNum + " не является кв. от числа " + secondNum );
}