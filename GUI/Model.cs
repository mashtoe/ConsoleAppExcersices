using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.GUI
{
    public class Model
    {
        public List<Video> videos { get; }

        public Model()
        {
            videos = new List<Video>();
        }
    }
}
