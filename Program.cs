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

            //MenuCreate menuCreate = new MenuCreate("Create");
            //menuCreate.MOdel = model;
            //items.Add(menuCreate);


            while (true)
            {
                int chosenItem = model.Menu(items, "Main");

                items[chosenItem].Action();
                //Console.WriteLine(chosenItem);
                Console.ReadLine();
            }
            


        }

        

    }
}