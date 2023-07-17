int Summ(int number)
{
    int sum = 0;
    while ( number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int GetInput(String tex)
{
    Console.Write(tex);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
Console.Write($"Сумма цифр в числе {number} равна {Summ(number)}."); 