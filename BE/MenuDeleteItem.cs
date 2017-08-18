using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    class MenuDeleteItem : MenuItem
    {
        public Video VideoHeld { get; set; }

        public MenuDeleteItem(string name) : base(name)
        {

        }

        public override void Action()
        {
            List<Video> videos = MOdel.Videos;
            for (int i = 0; i < videos.Count; i++)
            {
                if (VideoHeld.Id == videos[i].Id)
                {
                    videos.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
