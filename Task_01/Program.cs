// Задайте двумерный массив m на n, каждый элемент в массиве находится по 
// формуле: A[]= m+n
// Выведите полученный массив на экран.

Console.Clear();

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

int[,] CreateArray(int rows, int columns) // Метод заполнения массива
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for( int j = 0; j < columns; j++)
      {
         array[i, j] = i + j;
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
int[,] matrix = CreateArray(m, n);


// вывести массив на консоль:
ShowArray(matrix);


