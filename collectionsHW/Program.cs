using System;
using System.Linq;
using System.Collections.Generic;

namespace collectionsHW
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello!\n");
            ChooseOperation();
            AddCmd.Repeat('r');
        }
        public static void ChooseOperation()
        {
            Console.WriteLine("Input a command:" +
                "\n\"stack\"" +
                "\n\"queue\"" +
                "\n\"quit\"" +
                "\nanything else to repeat");
            Console.Write("\nYour command: ");
            switch (Console.ReadLine().ToLower())
            {
                case "stack":
                    #region stack
                    Console.WriteLine("\nType names of students that sent complete tasks. Type \"quit\" to finish.");
                    Stack<string> studentsStack = new Stack<string>();

                    while (true)
                    {
                        Console.Write($"Student №{studentsStack.Count + 1}: ");
                        string input = Console.ReadLine();
                        while (input.Length == 0) //не даём ввести пустое имя студента
                        {
                            Console.WriteLine("Student's name can't be empty, input again!");
                            Console.Write($"Student №{studentsStack.Count + 1}: ");
                            input = Console.ReadLine();
                        }
                        if (input.ToLower() == "quit")
                        {
                            if (studentsStack.Count == 0)
                            {
                                Console.WriteLine("There are currently 0 students in the list. Type \"quit\" to surely finish inputing students.");
                                input = Console.ReadLine();
                            }//если не был введён ни один студент, то выводится просьба подтвердить окончание ввода
                            break;
                        }
                        studentsStack.Push(input);
                    }

                    if (studentsStack.Count == 0)
                    {
                        Console.WriteLine("There are currently 0 students that sent comeplete tasks, so noone gets coffee!");
                    } //вывод сообщения о том, что ни один студент не отправил задание
                    Console.WriteLine();
                    while (studentsStack.Count > 0)
                    {
                        Console.WriteLine($"{studentsStack.Pop()} recieved a cup of coffee as a reward.");
                    } //с каждой иттерацией выводится на консоль и достаётся имя последнего сдавшего студента
                    #endregion
                    break;

                case "queue":
                    #region queue
                    Console.WriteLine("\nType names of students that sent complete tasks. Type \"quit\" to finish.");
                    Queue<string> studentsQueue = new Queue<string>();

                    while (true)
                    {
                        Console.Write($"Student №{studentsQueue.Count + 1}: ");
                        string input = Console.ReadLine();
                        while (input.Length == 0) //не даём ввести пустое имя студента
                        {
                            Console.WriteLine("Student's name can't be empty, input again!");
                            Console.Write($"Student №{studentsQueue.Count + 1}: ");
                            input = Console.ReadLine();
                        }
                        if (input.ToLower() == "quit")
                        {
                            if (studentsQueue.Count == 0)
                            {
                                Console.WriteLine("There are currently 0 students in the list. Type \"quit\" to surely finish inputing students.");
                                input = Console.ReadLine();
                            }//если не был введён ни один студент, то выводится просьба подтвердить окончание ввода
                            break;
                        }
                        studentsQueue.Enqueue(input);
                    }

                    if (studentsQueue.Count == 0)
                    {
                        Console.WriteLine("There are currently 0 students that sent comeplete tasks, so noone gets coffee!");
                    } //вывод сообщения о том, что ни один студент не отправил задание
                    Console.WriteLine();
                    while (studentsQueue.Count > 0)
                    {
                        Console.WriteLine($"{studentsQueue.Dequeue()} recieved a cup of coffee as a reward.");
                    } //с каждой иттерацией выводится на консоль и достаётся имя первого сдавшего студента
                    #endregion
                    break;

                case "quit":
                    break;

                default:
                    Console.Clear();
                    ChooseOperation();
                    break;
            }
        }
    }
}
