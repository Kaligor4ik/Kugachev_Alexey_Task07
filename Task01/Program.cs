using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit();
            DinamicArray<Unit> arr = new DinamicArray<Unit>(3);
            arr.Add(unit);
            arr.Add(unit);
            Console.WriteLine(arr.ToString()); //вывод неполного массива
            arr.Add(unit);
            Console.WriteLine(arr.ToString()); //вывод полного массива
            arr.Add(unit);
            Console.WriteLine(arr.ToString()); //вывод массива после расширения из-за недостаточной вместимости

            Unit[] arr2 = new Unit[] { new Unit(), new Unit(), new Unit(), new Unit(), new Unit(), new Unit(), new Unit(), new Unit() };
            arr.AddRange(arr2);
            Console.WriteLine(arr.ToString()); //вывод массива после добавления нового массива и расширения из-за недостаточной вместимости

            arr.Remove(2);
            Console.WriteLine(arr.ToString()); //вывод после удаления элемента массива со сдвигом ячеек

            arr.Insert(2, default(Unit));
            Console.WriteLine(arr.ToString()); //вывод после вставки элемента массива со сдвигом ячеек

            arr.Set(3, default(Unit));
            Console.WriteLine(arr.ToString());//вывод после изменения элемента массива по индексу

            Console.WriteLine("Элемент массива: " + arr.Get(4)); //получение элемента массива по индексу

            Console.ReadKey();
        }
    }

    class Unit
    {
        public Unit()
        {

        }
    }
}
