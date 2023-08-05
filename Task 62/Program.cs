// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива (например, 4):");
        int size = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[size, size];
        int num = 1;
        int startRow = 0;
        int endRow = size - 1;
        int startCol = 0;
        int endCol = size - 1;

        while (num <= size * size)
        {
            for (int i = startCol; i <= endCol; i++) // Заполняем верхнюю строку слева направо
            {
                array[startRow, i] = num++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++) // Заполняем правый столбец сверху вниз
            {
                array[i, endCol] = num++;
            }
            endCol--;

            for (int i = endCol; i >= startCol; i--) // Заполняем нижнюю строку справа налево
            {
                array[endRow, i] = num++;
            }
            endRow--;

            for (int i = endRow; i >= startRow; i--) // Заполняем левый столбец снизу вверх
            {
                array[i, startCol] = num++;
            }
            startCol++;
        }

        // Выводим заполненный массив
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0, 2} ", array[i, j]);
            }
            Console.WriteLine();
        }
