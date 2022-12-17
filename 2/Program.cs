// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

int Promt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int total(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum+= number % 10;
        number /= 10;
    }
    return sum;
}

int number = Promt("Input number");

System.Console.WriteLine($"Sum of number is {total(number)}");