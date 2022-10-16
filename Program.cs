// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Программа находит произведение двух матриц");

int row = AskForInput("строк");

int[,] array1 = FillArray(row, row, 1, 10);

Console.Write("\nCгенерированная матрица 1: \n");
PrintArray(array1);

int[,] array2 = FillArray(row, row, 1, 10);

Console.Write("\nCгенерированная матрица 2: \n");
PrintArray(array2);

int[,] resultArray = CalcMatrix(array1, array2);

System.Console.WriteLine("\nРезультирующая матрица : \n");
PrintArray(resultArray);


//////////////////////////// функции ////////////////////////////////////////////////////

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] filledArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            filledArray[i, j] = new Random().Next(min, max);
        }
    }
    return filledArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}

int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите - из скольки {str} должен состоять массив? :");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано количество {str} массива!\n");
        }
        else Console.WriteLine($"Некорректно указано количество {str} массива!\n");
    }
}

int[,] CalcMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[row, row];
    int count = 0;
    for(int i = 0; i < resultArray.GetLength(0); i++)
    {
        for(int k = 0; k < resultArray.GetLength(1); k++)
        {
             while(count < row)
             {
                resultArray[i,k] += array1[i, count] * array2[count, k];
                count++;
             }
            count = 0;
        }
    }
    return resultArray;
}

