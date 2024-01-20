// Задание 3. Совместная работа
// Семинар 4. Функции

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


int[] CrateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CrateArray(N);
if (array[0] == 0 || N > 8)
{
    Console.WriteLine($"размер > 8 элементов или 0 элемент = 0");
    return;
    
}

Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

int ConvertArrayToInteger(int[] array)
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    
    {
        result = result + array[i] * (int)Math.Pow(10, j);
    }
    return result;
}
Console.WriteLine($"Число: {ConvertArrayToInteger(array)}");