// Получите 3-ю цивру введенного числа(с начала)
// 1234567 =>3
// 7891=>9
// 32=> нет

Console.Write("введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет :)");
}
 else
{
    while (number > 999)
    {
        number /= 10;
    }
    Console.WriteLine($"{copyNumber}={number % 10}");
}