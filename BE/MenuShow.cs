using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    public class MenuShow : MenuItem
    {
        public MenuShow(string name) : base(name)
        {

        }

        public override void Action()
        {
            List<Video> videos = MOdel.Videos;
            List<MenuItem> menuItems = new List<MenuItem>();



            for (int i = 0; i < videos.Count; i++)
            {
                menuItems.Add(videos[i]);
            }

            int value = MOdel.Menu(menuItems, "Videos");
            menuItems[value].Action();

            
        }
    }
}
