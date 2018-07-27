using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Разработать программу, которая для заданной строки,
//которая меняет местами первую букву со второй, третью с четвертой и т.д
namespace LB1_5
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Введите строку: ");
                StringBuilder myArray = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Исходная строка: " + myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i%2==0)
                {
                    char tmp = myArray[i];
                    myArray[i] = myArray[i + 1];
                    myArray[i + 1] = tmp;
                }
                Console.Write(myArray[i]);
            }

            Console.ReadKey();
     

        }
    }
}
