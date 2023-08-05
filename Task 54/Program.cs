// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        Console.WriteLine("Исходный массив:");

        // Вывод исходного массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }

        // Упорядочивание элементов каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                // Находим максимальный элемент в оставшейся части строки
                int maxIndex = j;
                for (int k = j + 1; k < columns; k++)
                {
                    if (array[i, k] > array[i, maxIndex])
                    {
                        maxIndex = k;
                    }
                }

                // Меняем местами текущий элемент и максимальный элемент
                int temp = array[i, j];
                array[i, j] = array[i, maxIndex];
                array[i, maxIndex] = temp;
            }
        }

        Console.WriteLine("Упорядоченный массив:");

        // Вывод упорядоченного массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }



// int[,] array = {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 }
//         };

//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         Console.WriteLine("Исходный массив:");

//         // Вывод исходного массива
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }

//         // Упорядочивание элементов каждой строки по убыванию
//         for (int i = 0; i < rows; i++)
//         {
//             Array.Sort(array, i * columns, columns, new ReverseComparer());
//         }

//         Console.WriteLine("Упорядоченный массив:");

//         // Вывод упорядоченного массива
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }

//         // Реверсивный компаратор для сортировки по убыванию
// class ReverseComparer :IComparer
// {
//     public int Compare(object x, object y)
//     {
//         return ((IComparable)y).CompareTo(x);
//     }
// }
