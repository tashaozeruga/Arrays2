using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 9, 0, 3, 4, 2, 7, 6, 1, 5 }; //Наполнение массива
                        printarray(a); //Напечатать начальное состояние массива
            while (sort(a) == false) //Цикл сортировки, проходящий до тех пор, пока 
                // sort (a) не вернет true
            {
            }    
            
          
        }

        static void printarray(int[] a)
        {
            for (int i = 0; i < a.Length; i++) //Перебираем индекс от нуля до последнего элемента
                Console.Write(a[i] + "  "); // выводим на экран очередной элемент массива
            Console.WriteLine(); // Переходим в новую строку
        }

        static bool sort(int[] a)
        {
            bool isSorted = true; //Щитаем что массив успешно отсортирован
            int temp; // временная переменная, для хранения чисел, если их нужно поменять местами
            for (int i = 0; i < a.Length - 1; i++) // Цикл - перебирает элементы до предпоследнего
            {
                if (a[i] > a[i + 1]) // Выявляем нарушение порядка - больше ли число слева, того что справа
                {
                    temp = a[i + 1]; // Сохраняем правое число во временную переменную
                    a[i + 1] = a[i]; // А левое число копируем в ячейку правого
                    a[i] = temp; // Восстанавливаем меньшее число в левую ячейку
                    isSorted = false; // Значит что массив не отсортированф
                }

            }

            printarray(a); //Выводим новое состояние массива
            return isSorted; //Сообщаем наружу/наверх отсортирован или не отсортирован массив
        }
     }
}
