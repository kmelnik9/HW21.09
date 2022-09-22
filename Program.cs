//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

System.Console.WriteLine("Задача 54");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}

int[,] SortArray(int[,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<(arr.GetLength(1)-1); j++)
        {
            for (int k=j+1; k<(arr.GetLength(1)); k++)
            {
                if (arr[i,j]<arr[i,k])
                {
                    int temp = arr[i,j];
                    arr[i,j]=arr[i,k];
                    arr[i,k]= temp;
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
for (int i=0; i<arr.GetLength(0); i++)
{
    for (int j = 0; j<arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] arr1 = GetArray(3,4);
PrintArray(arr1);
System.Console.WriteLine();
int[,] arr2 = SortArray(arr1);
PrintArray(arr2);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine();
System.Console.WriteLine("Задача 56");

int[] SumString (int [,] Array)
{
    int[] result = new int [Array.GetLength(0)];
    int sum = 0;
    for (int i=0; i<Array.GetLength(0); i++)
    {
        for (int j=0; j<Array.GetLength(1); j++)
        {
            sum += Array[i,j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
}

void MinString (int [] arr)
{
    int min = arr[0];
    int minPosition = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (arr[i]<min)
        {
            minPosition = i;
        }
    }
    System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {minPosition+1}");
}

PrintArray(arr1);
int[] arr3 = SumString(arr1);
System.Console.WriteLine($"[{string.Join(", ", arr3)}]");
MinString(arr3);

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

System.Console.WriteLine();
System.Console.WriteLine("Задача 58");

int[,] ArrayMultiplication (int[,] Array1, int [,] Array2)
{
    int [,] result = new int [Array1.GetLength(0),Array2.GetLength(1)];
    for (int i=0; i<Array1.GetLength(0); i++)
    {
        for (int j=0; j<Array2.GetLength(1); j++)
        {
            for (int k=0; k<Array1.GetLength(1); k++)
            {
            result[i,j] += Array1[i,k]*Array2[k,j];
            }
        }
    }
    return result;
}

int[,] arr4 = GetArray(2,2);
PrintArray(arr4);
System.Console.WriteLine();
int[,] arr5 = GetArray(2,2);
PrintArray(arr5);
System.Console.WriteLine();
int[,] arr45 = ArrayMultiplication(arr4,arr5);
PrintArray(arr45);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

System.Console.WriteLine("Задача 60");

void GetArray3(int m, int n, int g)
{
    int[,,] result = new int[m,n,g];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            for (int k = 0; k<g; k++)
            {
                result[i,j,k] = new Random().Next(10,100);
                System.Console.Write($"{result[i,j,k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

GetArray3(2, 2, 2);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

System.Console.WriteLine("Задача 62");

void GetSpire(int n, int m)
{
    int[,] mas = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;
    for (int i = 0; i < mas.Length; i++)
    {
        mas[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
        }               

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
           Console.Write(mas[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

GetSpire(4,4);

