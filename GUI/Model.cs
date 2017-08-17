using ConsoleAppExcersices.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.GUI
{
    public class Model
    {
        public List<Video> Videos { get; }

        public Model()
        {
            Videos = new List<Video>();
        }

        public int Menu(List<MenuItem> items, string nameOfMenu)
        {
            Console.Clear();
            Console.WriteLine($"------{nameOfMenu}------\n");

            MenuBack back = new MenuBack("(Leave)");
            back.MOdel = this;
            items.Add(back);

            if (items.Count > 0)
            {
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
            else
            {
                return -1;
            }
            

        }
    }
}
