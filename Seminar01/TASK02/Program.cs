Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Введено отрецательное число N! ");
    N = N * -1;
}
int negativN = N * -1;
while (negativN <= N)
{
    Console.WriteLine(negativN + "\t");
    negativN++;
}