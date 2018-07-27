using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_1
{
    class Array
    {
        //Методы создания и наполнения одномерного массива 

        public int[] CreateSimpleArray(int n)
        {

            int[] mySimpleArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Введите {0}-й элемент массива");
                    mySimpleArr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели недопустимый символ");
                }
            }
            return mySimpleArr;
        }
        // Метод изменения массива
        public void Change(int[] MySimpleArr)
        {
            Console.WriteLine("Введите любое целое число");
            try
            {
                int number = int.Parse(Console.ReadLine());
                for (int i = 0; i < MySimpleArr.Length; i++)
                {
                    if (MySimpleArr[i] < number)
                    {
                        MySimpleArr[i] = number;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели недопустимое число или символ");
            }
        }
        public void Print(int[] MySimpleArr)
        {
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int j = 0; j < MySimpleArr.Length; j++)
            {
                Console.Write(MySimpleArr[j] + ",");
            }
            Console.WriteLine();
        }



        //Методы создания и наполнения одномерного массива 

        public int[,] MyMultiArray(int n, int m)
        {

            int[,] MyMultiArray = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    try
                    {
                        Console.WriteLine("Введите [{0},{1}]-й элемент массива", i, j);
                        MyMultiArray[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели недопустимый символ");
                    }
                }

            }
            return MyMultiArray;
        }

        public void ChangeMultiArr(int[,] MyMultiArray, int n, int m)
        {
            Console.WriteLine("Введите любое целое число");
            try
            {
                int number = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (MyMultiArray[i, j] < number)
                        {
                            MyMultiArray[i, j] = number;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели недопустимое число или символ");
            }
        }
        public void PrintMultiArr(int[,] MyMultiArray, int n, int m)
        {
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write(MyMultiArray[i,j] + ",");
                }

            Console.WriteLine();
        }

    }
}





//Чтобы после введения недопустимого символа программа прекращала работу