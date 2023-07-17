void ConstructionDegree(int number1, int number2)
{
    int result = Convert.ToInt32(Math.Pow(number1, number2));
    Console.WriteLine($"{number1}, {number2} -> {result}");
}

int GetInput(String tex)
{
    Console.Write(tex);
    return Convert.ToInt32(Console.ReadLine());
}

int FirstNumber = GetInput("Введите число: ");
int SecondNumber = GetInput("Введите число: ");

ConstructionDegree(FirstNumber, SecondNumber);