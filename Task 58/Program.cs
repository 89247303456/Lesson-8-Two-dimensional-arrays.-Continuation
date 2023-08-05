//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

 
        int[,] matrix1 = {{2, 4}, {3, 2}};
        int[,] matrix2 = {{3, 4}, {3, 3}};

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Результирующая матрица:");
        PrintMatrix(result);
    

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new InvalidOperationException("Невозможно умножить матрицы");
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
                if (j < cols - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }











// Console.WriteLine("Введите значения для первой матрицы:");

//         int[,] matrix1 = GetMatrixFromInput();

//         Console.WriteLine("Введите значения для второй матрицы:");

//         int[,] matrix2 = GetMatrixFromInput();

//         int[,] result = MultiplyMatrices(matrix1, matrix2);

//         Console.WriteLine("Результирующая матрица:");
//         PrintMatrix(result);
    

//     static int[,] GetMatrixFromInput()
//     {
//         int rows = GetNumberFromInput("Введите количество строк: ");
//         int cols = GetNumberFromInput("Введите количество столбцов: ");

//         int[,] matrix = new int[rows, cols];

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 matrix[i, j] = GetNumberFromInput($"Введите значение для элемента [{i}, {j}]: ");
//             }
//         }

//         return matrix;
//     }

//     static int GetNumberFromInput(string prompt)
//     {
//         int number;

//         do
//         {
//             Console.Write(prompt);
//         } while (!int.TryParse(Console.ReadLine(), out number));

//         return number;
//     }

//     static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
//     {
//         int rows1 = matrix1.GetLength(0);
//         int cols1 = matrix1.GetLength(1);
//         int rows2 = matrix2.GetLength(0);
//         int cols2 = matrix2.GetLength(1);

//         if (cols1 != rows2)
//         {
//             throw new InvalidOperationException("Невозможно умножить матрицы");
//         }

//         int[,] result = new int[rows1, cols2];

//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < cols2; j++)
//             {
//                 for (int k = 0; k < cols1; k++)
//                 {
//                     result[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }
//             }
//         }

//         return result;
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j]);
//                 if (j < cols - 1)
//                 {
//                     Console.Write(" ");
//                 }
//             }
//             Console.WriteLine();
//         }
//     }    
