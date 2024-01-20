//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


Console.Clear();

Console.WriteLine("Введите ваши координаты X: ");
int CoordX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ваши координаты Y: ");
int CoordY = Convert.ToInt32(Console.ReadLine());

if (CoordX > 0 && CoordY > 0)
{
    Console.WriteLine("Ваши координаты находятся в I плоскости");
}
else if (CoordX < 0 && CoordY > 0)
{
    Console.WriteLine("Ваши координаты находятся в II плоскости");
}
else if (CoordX < 0 && CoordY < 0)
{
    Console.WriteLine("Ваши координаты находятся в III плоскости");
}
else if (CoordX > 0 && CoordY < 0)
{
    Console.WriteLine("Ваши координаты находятся в IV плоскости");
}
else
{
    Console.WriteLine("Точка находится в начале координат");
}
