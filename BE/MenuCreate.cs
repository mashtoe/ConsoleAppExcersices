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
            //Console.Clear();
            Console.WriteLine("Name your video");
            string name = Console.ReadLine();

            int largestId = 0;
            List<Video> videos = MOdel.Videos;
            for (int i = 0; i < videos.Count; i++)
            {
                if (largestId < videos[i].Id)
                {
                    largestId = videos[i].Id;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Enter the content of the video");

            string content = Console.ReadLine();
            Video video = new Video(name, largestId + 1, content);
            MOdel.Videos.Add(video);
            Console.Clear();
            Console.WriteLine($"Video {video.Name} added. Press any enter to return to menu");
            Console.ReadLine();
        }
    }
}
