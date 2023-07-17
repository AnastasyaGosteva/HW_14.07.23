void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}

int [] arr = new int [8];
Console.WriteLine("Введите любые 8 чисел от 1 до 100 для инициализации массива: ");
FillArray(arr);
Console.Clear();
Console.WriteLine($"Ваш массив [{String.Join(",", arr)}].");
