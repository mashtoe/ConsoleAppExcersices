using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    class MenuUpdateItem : MenuItem
    {
        public Video VideoHeld { get; set; }

        public MenuUpdateItem(string name) : base(name)
        {
        }

        public override void Action()
        {
            Console.WriteLine("Type the new name for the video");
            string newName = Console.ReadLine();
            VideoHeld.Name = newName;

        }
    }
}
