﻿// ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Создание трехмерного массива размером 2 x 2 x 2
        int[,,] array = new int[2, 2, 2];

        // Переменная для хранения уже использованных чисел
        bool[] usedNumbers = new bool[100];

        Random rand = new Random();

        // Заполнение массива неповторяющимися двузначными числами
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    int number;
                    do
                    {
                        number = rand.Next(10, 100);
                    } while (usedNumbers[number]);

                    array[i, j, k] = number;
                    usedNumbers[number] = true;
                }
            }
        }

        // Вывод массива с указанием индексов
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine("{0}({1},{2},{3})", array[i, j, k], i, j, k);
                }
            }
        }