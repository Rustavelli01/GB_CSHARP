//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//--------------------------Схема-----------------------
//1. Задать числа
//2. Сравинить заданные числа
//3. Выдать результат
//-------------------------Решение---------------------

Console.Clear();

Console.WriteLine("А теперь давайте поиграем с числами и сравним их!");

Console.Write("Задайте первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Ваше первое число больше остальных->" + num1);
}
else if (num2 > num3)
{
    Console.WriteLine("ваше второе число больше остальных->" + num2);
}
else if (num3 > num1)
{
    Console.WriteLine("Ваше третье число больше остальных->" + num3);
}