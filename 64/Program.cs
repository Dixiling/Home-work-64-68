Console.WriteLine("Задача 64"); //Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToNum(number, count);

void NaturalToNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToNum(n, count + 1);
        Console.Write(count + " ");
    }
}
