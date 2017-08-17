using ConsoleAppExcersices.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    public class MenuCreate : MenuItem
    {
        

        public MenuCreate(string name) : base(name)
        {
            Console.WriteLine("The name is: " + name);
        }

        public override void Action()
        {
            Console.Clear();
            Console.WriteLine("Name your video");
            string name = Console.ReadLine();
            Video video = new Video(name);
        }
    }
}
