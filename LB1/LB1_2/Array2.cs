using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_2
{
    class Array2
    {
        //Методы создания и наполнения одномерного массива 

        public int[] CreateSimpleArray(int n)
        {

            int[] MySimpleArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Введите {0}-й элемент массива");
                    MySimpleArr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели недопустимый символ");
                }
            }
            return MySimpleArr;
        }
        // Метод изменения массива
        public void Change(int[] MySimpleArr)
        {
            int min = MySimpleArr[0];
            for (int i = 1; i < MySimpleArr.Length; i++)
            {

                if (min > MySimpleArr[i])
                {
                    min = MySimpleArr[i];
                }
            }
            Console.WriteLine("Номера всех минимальных элеменов массива: ");
            List<int> numbers = new List<int>();//если элемент не один
            for (int j = 0; j < MySimpleArr.Length; j++)
            {
                if (min == MySimpleArr[j])
                {
                    numbers.Add(j);
                }
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
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

        //Методы создания и наполнения многомерного массива 

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
            int min = MyMultiArray[0, 0];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > MyMultiArray[i, j])
                    {
                        min = MyMultiArray[i, j];
                    }
                }

            }
            Console.WriteLine("Номера всех минимальных элеменов массива: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min == MyMultiArray[i, j])
                    {
                        Console.WriteLine("[{0},{1}]", i, j);
                    }
                }

            }
        }

        public void PrintMultiArr(int[,] MyMultiArray, int n, int m)
        {
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(MyMultiArray[i, j] + ",");
                }
            }

            Console.WriteLine();
        }
    }
}
