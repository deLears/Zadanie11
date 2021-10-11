using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    /*Разработать структуру для решения линейного уравнения 0=kx+b.Коэффициенты уравнения k, b реализовать
     * с помощью полей вещественного типа.Для решения уравнения предусмотреть метод Root.
     * Создать экземпляр разработанной структуры.Осуществить использование экземпляра в программе.
     */

    public struct Root
    {
        public int Kvar { get; set; }
        public int Bvar { get; set; }
        public int Xvar { get; set; }
        public Root(int x, int b, int k)
        {
            this.Kvar = k;
            this.Bvar = b;
            this.Xvar = x;
            return;
        }
        public void EnterData()
        {
            Console.WriteLine("Введите значение K=");
            Kvar = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите значение B=");
            Bvar = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayInfo()
        {
            try
            {
                Xvar = -Bvar / Kvar;
                Console.WriteLine("K={0}", Xvar);
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на ноль, т.к. k=0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат чисел");
            }

        }
    }


    class Zadanie11
    {
        static void Main(string[] args)
        {
            Root root = new Root();
            root.EnterData();
            root.DisplayInfo();
        }
    }
    
    
}
    


