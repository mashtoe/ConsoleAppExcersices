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
            menuCreate.MOdel = model;
            items.Add(menuCreate);

            MenuShow menuShow = new MenuShow("List videos");
            menuShow.MOdel = model;
            items.Add(menuShow);

            int chosenItem = 0;
            while (chosenItem != -1)
            {
                chosenItem = model.Menu(items, "Main");
                Console.Clear();
                if (chosenItem != -1)
                {
                    items[chosenItem].Action();
                }
            }
        }
    }
}