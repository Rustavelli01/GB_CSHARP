// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.




Console.WriteLine("Введите нужное количество трехзначных чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;


for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");

    if (array[i] % 2 == 0)
    {
        count++;
    }



}
    Console.WriteLine($"Четных чисел в массиве: {count}");

