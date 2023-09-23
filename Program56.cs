// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка



int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 9);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int minSum = int.MaxValue;
int minSumRow = -1;

void SummArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
            {
                summa = summa + array[i,j];
            }

            if (summa < minSum)
            {
                minSum = summa;
                minSumRow = i;
                    
            }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {minSumRow +1}");  
    
}


int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);
Print2DArray(myArray);

Console.WriteLine();
SummArray(myArray);