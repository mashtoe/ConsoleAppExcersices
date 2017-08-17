using ConsoleAppExcersices.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices
{
    public abstract class MenuItem
    {
        public Model Model { get; set; }
        public string Name { get;}

        public MenuItem(string name)
        {
            this.Name = name;
        }

        public abstract void Action();

    }
}
