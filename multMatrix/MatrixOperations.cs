using System;
using System.Collections.Generic;
using System.Text;

public static class Matrix
{
    public static int[,] Input(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t");
            }
            Console.WriteLine();
        }
        return matrix;
    } //ручной ввод значений матрицы
    public static int[,] GetRand(int[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(0, 9);
            }
        }
        return matrix;
    } //заполнение матрицы случайными числами от 0 до 9
    public static int[,] GetRand(int[,] matrix, int startRand, int endRand)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(startRand, endRand);
            }
        }
        return matrix;
    } //заполнение матрицы случайными числами в заданном диапазоне
    public static void Output(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    } //вывод матрицы
    public static int[][] Input(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t");
            }
            Console.WriteLine();
        }
        return matrix;
    } //ручной ввод значений матрицы
    public static int[][] GetRand(int[][] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = random.Next(0, 9);
            }
        }
        return matrix;
    } //заполнение матрицы случайными числами от 0 до 9
    public static int[][] GetRand(int[][] matrix, int startRand, int endRand)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = random.Next(startRand, endRand);
            }
        }
        return matrix;
    } //заполнение матрицы случайными числами в заданном диапазоне
    public static void Output(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + "\t");
            }
            Console.WriteLine();
        }
    } //вывод матрицы
    public static int[,] Multiply(int[,] matrixOne, int[,] matrixTwo) //умножение матрицы
    {
        int[,] newMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrixTwo.GetLength(0); k++)
                {
                    newMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                }
            }
        }
        return newMatrix;
    }
}
