using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Заменить все элементы, меньшие заданного числа, этим числом.
namespace LB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с одномерным массивом");
            Array myArr = new Array();
            Console.WriteLine("Введите размерность одномерного массива");
            int lenghtArr = int.Parse(Console.ReadLine());
            int[] simpleArr = myArr.CreateSimpleArray(lenghtArr);
            myArr.Print(simpleArr);
            myArr.Change(simpleArr);
            myArr.Print(simpleArr);

            Console.WriteLine("Нажмите любую клавишу....");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Работа с многомерным массивом");
            Console.WriteLine("Введите размерность многомерного массива");
            int lFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размерность многомерного массива");
            int lSecond = int.Parse(Console.ReadLine());
            int [,] multiArr =  myArr.MyMultiArray(lFirst, lSecond);
            myArr.PrintMultiArr(multiArr, lFirst, lSecond);
            myArr.ChangeMultiArr(multiArr, lFirst, lSecond);
            myArr.PrintMultiArr(multiArr, lFirst, lSecond);

            Console.ReadKey();
        }
    }
}
