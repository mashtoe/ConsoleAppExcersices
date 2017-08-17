using ConsoleAppExcersices.BE;
using ConsoleAppExcersices.GUI;
using System;
using System.Collections.Generic;

namespace ConsoleAppExcersices
{
    class Program
    {
        private List<MenuItem> items;
        private Model model;

        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            model = new Model();
            items = new List<MenuItem>();

            MenuCreate menuCreate = new MenuCreate("Create");
            menuCreate.Model = model;
            items.Add(menuCreate);


            int chosenItem = CreateMenu(items);

            items[chosenItem].Action();
            //Console.WriteLine(chosenItem);
            Console.ReadLine();


        }

        private int CreateMenu(List<MenuItem> items)
        {
            Console.Clear();
            Console.WriteLine("------Menu------\n");
            
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + items[i].Name);
            }

            int chosenItem;
            while ((!int.TryParse(Console.ReadLine(),out chosenItem)) || chosenItem <= 0 || chosenItem > items.Count)
            {
                Console.WriteLine($"Enter number between 1-{items.Count}");
            }
            return chosenItem-1;
            
        }

    }
}