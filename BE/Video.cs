using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices
{
    

    public class Video
    {
        public string Name { get; set;}
        public int Id { get; set; }


        public Video(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
