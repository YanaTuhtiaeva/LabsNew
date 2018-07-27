using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Вывести на экран номера всех минимальных элементов.
namespace LB1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с одномерным массивом");
            Array2 myArr = new Array2();
            Console.WriteLine("Введите размерность одномерного массива");
            int lenghtArr = int.Parse(Console.ReadLine());
            int[] simpleArr = myArr.CreateSimpleArray(lenghtArr);
            myArr.Print(simpleArr);
            myArr.Change(simpleArr);
           

            Console.WriteLine("Нажмите любую клавишу....");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Работа с многомерным массивом");
            Console.WriteLine("Введите размерность многомерного массива");
            int lFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размерность многомерного массива");
            int lSecond = int.Parse(Console.ReadLine());
            int[,] multiArr = myArr.MyMultiArray(lFirst, lSecond);
            myArr.PrintMultiArr(multiArr, lFirst, lSecond);
            myArr.ChangeMultiArr(multiArr, lFirst, lSecond);
           

            Console.ReadKey();
        }
    }
}
