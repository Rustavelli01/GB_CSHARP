// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип данных[] имя_массива[] = new int [размер]

// int size = 10;
// int [] array = new int[size]; //мы создали массив
// Размером size элементов
// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };
// Console.Write("Введите число для поиска в массиве: ");
// int numberForSearch = Convert.ToInt32(Console.ReadLine());

// bool isFound = false; // Если isFound =folse, числа в массиве нет

// for (int i = 0; i < array.Length; i++)
// {
    // if (numberForSerch == array[i])
    // {
    //     Console.WriteLine("Да");
    //     break; //"ломаем" цикл, когда нашли нужный элемент
    // }
    // else
    // {
    //     Console.WriteLine("Нет");
    // }

//     if (numberForSearch == array[i])
//     {
//         isFound = true; //элемент в массиве найден
//         break;
//     }
// }
// if (isFound) //Isfound == true
// {
//     Console.WriteLine("Да");
// }
// else  //isFound ==false
// {
//     Console.WriteLine("Нет");
// }


int[] array1 = { 11, 22, 33, 44, 55, 66, 77 };
Console.Write("Введите число для поиска в массиве: ");
int numberForSearch1 = Convert.ToInt32(Console.ReadLine());
string isFound1 = "не найден"; // Если isFound=false, числа в массиве нет
// точка старта, условие, увелич. переменной - счетчика
for (int i = 0; i < array1.Length; i++)
{
    if (numberForSearch1 == array1[i])
    {
        isFound1 = "найден"; // Элемент в массиве найден :)
        break;
    }
}
Console.WriteLine($"Элемент {numberForSearch1} : {isFound1}");