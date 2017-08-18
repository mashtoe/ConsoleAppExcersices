using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    class MenuShowItem : MenuItem
    {
        public Video VideoHeld { get; set; }

        public MenuShowItem(string name) : base(name)
        {
        }

        public override void Action()
        {
            VideoHeld.PlayRecording();
        }
    }
}
