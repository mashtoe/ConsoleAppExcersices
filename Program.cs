using System;

namespace ConsoleAppExcersices
{
    class Program
    {
        string[] items = { "Create", "Read", "Update", "Delate" };

        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            
            int chosenItem = CreateMenu(items);
            Console.WriteLine(chosenItem);
            Console.ReadLine();


        }

        private int CreateMenu(string[] items)
        {
            Console.Clear();
            
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + items[i]);
            }

            int chosenItem;
            while (!int.TryParse(Console.ReadLine(),out chosenItem) && chosenItem > 0 && chosenItem < 6)
            {
                Console.WriteLine("Enter number between 1-5");
            }
            return chosenItem;
            
        }

    }
}