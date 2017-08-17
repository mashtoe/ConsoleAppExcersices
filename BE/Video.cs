using ConsoleAppExcersices.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices
{
    

    public class Video: MenuItem
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public Video(string name, int id, string content) : base(name)
        {
            this.Id = id;
            this.Content = content;
        }

        //public string Name { get; set;}
        

        

        public override void Action()
        {                              
            Console.WriteLine($"(ID: {Id}) {Name}: {Content}");
            Console.ReadLine();
        }
    }
}
