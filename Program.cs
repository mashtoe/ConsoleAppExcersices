using ConsoleAppExcersices.BE;
using ConsoleAppExcersices.GUI;
using System;
using System.Collections.Generic;

namespace ConsoleAppExcersices
{
    class Program
    {
        private Model model;

        static void Main(string[] args)
        {
            Program program = new Program();
        }

        public Program()
        {
            model = new Model();

            bool running = true;
            while (running)
            {
                List<MenuItem> items = CreateItems();

                int chosenItem = model.Menu(items, "Main");
                Console.Clear();

                items[chosenItem].Action();
                if (chosenItem == items.Count-1)
                {
                    running = false;
                }   
            }
        }

        public List<MenuItem> CreateItems()
        {
            List<MenuItem> items = new List<MenuItem>();

            MenuCreate menuCreate = new MenuCreate("Create");
            menuCreate.MOdel = model;
            items.Add(menuCreate);

            MenuShow menuShow = new MenuShow("List videos");
            menuShow.MOdel = model;
            items.Add(menuShow);
            return items;
        }
    }
}