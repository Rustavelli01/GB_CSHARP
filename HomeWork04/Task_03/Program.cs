// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
int[] numbers = {1, 3, 5, 6, 7, 8}; 
int temp;

Console.Write("Заданный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}

for (int i = 0; i < numbers.Length / 2; i++)
{

temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
Console.WriteLine();
Console.Write("Развернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}