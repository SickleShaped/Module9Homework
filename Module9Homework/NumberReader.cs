using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Homework
{
    internal class NumberReader
    {
        static string[] array = { "Алешин", "Кузьмин", "Караваев", "Неженцев", "Волков" };

        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read()
        {
            Console.WriteLine("Введите число 1 или 2: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number != 1 && number != 2) { throw new WrongNumberException("ОШИБКА"); }
            NumberEntered(number);
        }
        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }

        public static void SortArray(int number)
        {
            switch(number)
            {
                case 1: Array.Sort(array);
                    break;

                case 2: Array.Sort(array);
                    Array.Reverse(array);
                    break;

            }

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
