using System;
using System.Collections.Generic;
using System.Text;

public static class Array
{
    public static int[] Input(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    } //ручной ввод значений матрицы
    public static int[] GetRand(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i] = random.Next(0, 9);
        }
        return array;
    } //заполнение матрицы случайными числами от 0 до 9
    public static int[] GetRand(int[] array, int startRand, int endRand)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startRand, endRand);
        }
        return array;
    } //заполнение матрицы случайными числами в заданном диапазоне
    public static void Output(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
    } //вывод матрицы
    public static int[] QuickSort(int[] array)
    {
        return QuickSort(array, 0, array.Length - 1);
    }
    private static int[] QuickSort(int[] array, int left, int right)
    {
        if (left < right) //условие, необходимое для рекурсий
        {
            int pivot = Partition(array, left, right); //сортируем текущий подмассив
            if (pivot > 1)
                QuickSort(array, left, pivot - 1);
            if (pivot + 1 < right)
                QuickSort(array, pivot + 1, right);
        }
        return array;
    }
    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];
        while (true)
        {
            while (array[left] < pivot)
                left++;
            while (array[right] > pivot)
                right--;
            if (left < right)
            {
                AddCmd.Swap(ref array[left], ref array[right]);
                //если ближайшие два числа равны, то сверяем то, которое правее (то есть увеличиваем индекс на 1) дабы не было ошибок
                if (array[left] == array[right])
                    left++;
            }
            else
                return right;
        }
    }
}
