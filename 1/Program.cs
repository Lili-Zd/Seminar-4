// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int power(int one, int two)
{
    int number = 1;
    for (int i = 0; i < two; i++)
    {
        number = number * one;
    }
    return number;
}

int one = Promt("Input A");
int two = Promt("Input B");

System.Console.WriteLine($"Power of number is {power(one, two)}");