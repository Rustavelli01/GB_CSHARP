// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.


Console.Clear();


Console.Write("введите число:");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 10)
{
    Console.WriteLine(number);
}
else
{
    while (number > 0)
    {
        int copyNumber = number % 10;
        number /= 10;
        if (number > 0)
        {
            Console.Write(copyNumber + ", ");
        }
        else
        {
            Console.WriteLine(copyNumber);
        }
    }
}

// Не получается развернуть в обратном направлении