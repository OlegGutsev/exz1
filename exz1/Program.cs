using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exz1
{
    class Person : ICard
    {
        private int money;


        public void Add(int m)
        {
            
      
            try
            {
                if (m < 0)
                    throw new Exception();
                money += m;
                Console.WriteLine("Было добавлено: " + m);
            }
            catch (Exception e)
            {
                Console.WriteLine("добавлено меньше нуля");
            }

        }

        public void Remove(int m)
        {
            Console.WriteLine("Было удалено: " + m);
            money -= m;
        }

        public int Sum()
        {
            try
            {
                if (money < 0)
                    throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("Сумма меньше нуля");
            }
            return money;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.Add(15);
            pers.Add(25);
            Console.WriteLine("Сумма: " + pers.Sum());
            pers.Remove(10);
            Console.WriteLine("Сумма: " + pers.Sum());
            pers.Add(-15);
            Console.ReadLine();
        }
    }
}
