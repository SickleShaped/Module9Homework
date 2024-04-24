namespace Module9Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///первое задание - прошу пояснения. ЧТо такое МАССИВ ИСКЛЮЧЕНИЙ в задании?
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        throw new NullReferenceException("Null-reference exception");
                        break;
                    case 2:
                        throw new TimeoutException("TimeOut Exception");
                        break;
                    case 3:
                        throw new ArgumentException("Argument exception");
                        break;
                    case 4:
                        throw new InvalidOperationException("Invalid opeation exception");
                        break;
                    case 5:
                        throw new CustomException("Ого, это мое исключение!");
                        break;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ///Второе задание
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += NumberReader.SortArray;
            Console.WriteLine();
            try
            {
                numberReader.Read();

            }
            catch(WrongNumberException ex)
            {
                Console.WriteLine("Невереное число. Нужно 1 или 2");
            }

        }

        public void LastNameAZSorting()
        {

        }

        public void LastNameZASorting()
        {

        }
    }
}