// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//РЕШЕНИЕ

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);
// SecondArray(array);
// Console.WriteLine();
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SecondArray (int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             for (int k = j + 1; k < array.GetLength(1); k++){
//                 if (array[i,k] > array[i,j]){
//                     int temp = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = temp;
                    
//                 }
//             }
//         }
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// РЕШЕНИЕ

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int SecondArray (int[,] array){
//     int rows = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++){
//         minsum = minsum + array[0,i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++){
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++){
//             sum = sum + array[i,j];
//         }
//         if (minsum > sum){
//             minsum = sum;
//             rows = i;
//         }
//     }
//     return rows;
// }
// Console.WriteLine($"Строка с наименьшей суммой = {SecondArray(array)}");



// Задача 58: Задайте две квадратные матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк 1 матрицы: ");
// int rowsA = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов 1 матрицы: ");
// int columnsA = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество строк 2 матрицы: ");
// int rowsB = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов 2 матрицы: ");
// int columnsB = int.Parse(Console.ReadLine()!);

// if (columnsA != rowsB){
//     Console.WriteLine("Такое умножать нельзя!!!");
// }

// int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
// int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);

// PrintArray(arrayA);
// Console.WriteLine();
// PrintArray(arrayB);
// Console.WriteLine();
// PrintArray(GlobalMatrix(arrayA, arrayB));


// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] Array){
//     for (int i = 0; i < Array.GetLength(0); i++){
//         for (int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GlobalMatrix (int[,] arrayA, int[,] arrayB){
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++){
//         for (int j = 0; j < arrayB.GetLength(1); j++){
//             for (int k = 0; k < arrayA.GetLength(1); k++){
//                 arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
//             }
//         }
//     }
//     return arrayC;
// }


// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// РЕШЕНИЕ

Console.WriteLine("Введите три числа (через пробел): ");
string[] nums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray3(new int[] {int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99);
PrintArray3(array);

int[,,] GetArray3(int[] sizes, int min, int max){
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            int k = 0;
            while (k < result.GetLength(2)){
                int element = new Random().Next(min, max +1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int e1){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                if (array[i, j, k] ==  e1) return true;
            }
        }
    }
    return false;
}

void PrintArray3(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}