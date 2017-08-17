using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.GUI
{
    public class Model
    {
        public List<Video> videos { get; }

        public Model()
        {
            videos = new List<Video>();
        }

        public int Menu(List<MenuItem> items, string nameOfMenu)
        {
            Console.Clear();
            Console.WriteLine($"------{nameOfMenu}------\n");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + items[i].Name);
            }

            int chosenItem;
            while ((!int.TryParse(Console.ReadLine(), out chosenItem)) || chosenItem <= 0 || chosenItem > items.Count)
            {
                Console.WriteLine($"Enter number between 1-{items.Count}");
            }
            return chosenItem - 1;

        }
    }
}
