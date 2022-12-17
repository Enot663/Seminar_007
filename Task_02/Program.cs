// Создайте двумерный массив, найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты.

Console.Clear();

int[,] Square(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }        
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange) // Метод заполнения массива
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string message) // Метод ввода данных двумерного массива
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя m и n:

int m = EnterNumber("Введите число строк массива: ");
int n = EnterNumber("Введите число столбцов массива: ");

// создаем и заполняем двумерный массив:
int[,] matrix = CreateRandomArray(m, n, 1, 10);
ShowArray(matrix);
int[,] matrixSquare = Square(matrix);

// вывести массив на консоль:
Console.WriteLine();
ShowArray(matrixSquare);