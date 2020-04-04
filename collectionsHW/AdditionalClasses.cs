using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsHW
{
    public static class AddCmd
    {
        public static void Repeat(char repeatKey)
        {
            Console.WriteLine("===============================\n" +
                        $"Press \"{repeatKey}\" to repeat the program.");
            if (Console.ReadKey().KeyChar == repeatKey) //если нажата repeatKey, то программа перезапустится, предварительно очистив консоль
            {
                Console.Clear();
                Program.Main();
            }
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static bool IsPrime(int num)  //функция для определения является ли число простым
        {
            //если остаток от деления на 2 не равен 0, то начинается проверка на простоту
            if (num % 2 != 0 && num >= 2)
            {
                /*
                вводим переменную для условия продолжения цикла, чтобы не высчитывать корень в каждой итеррации 
                наименьший делитель числа не превосходит корень этого числа
                */
                int sqrtNum = (int)Math.Sqrt(num);
                for (int j = 3; j <= sqrtNum; j += 2)
                    if (num % j == 0) //если делится каким-либо числом нацело, то false
                        return false;
                return true;
            }
            //так как из-за первого условия мы можем попасть на двойку, то проверяем чтобы не допустить ошибку
            if (num == 2)
                return true;
            return false;
        }
    }
}
