using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    

    public class Actor
    {
        public List<string> Frames { get; }
        public char Tegn { get; }

        public Actor(char tegn)
        {
            this.Tegn = tegn;

            Frames = new List<string>();
        }
    }
}
