using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    class MenuUpdate : MenuItem
    {
        public MenuUpdate(string name) : base(name)
        {
        }

        public override void Action()
        {
            List<Video> videos = MOdel.Videos;
            List<MenuItem> menuItems = new List<MenuItem>();

            for (int i = 0; i < videos.Count; i++)
            {
                MenuUpdateItem item = new MenuUpdateItem(videos[i].Name);
                item.VideoHeld = videos[i];
                menuItems.Add(item);
            }

            int value = MOdel.Menu(menuItems, "Update name of a video");
            menuItems[value].Action();

        }
    }
}
