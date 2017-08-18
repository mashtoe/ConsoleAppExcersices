using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices.BE
{
    class MenuDelete : MenuItem
    {
        public MenuDelete(string name) : base(name)
        {
        }

        public override void Action()
        {
            List<Video> videos = MOdel.Videos;
            List<MenuItem> menuItems = new List<MenuItem>();

            for (int i = 0; i < videos.Count; i++)
            {
                MenuDeleteItem item = new MenuDeleteItem(videos[i].Name);
                item.VideoHeld = videos[i];
                item.MOdel = MOdel;
                menuItems.Add(item);
            }

            int value = MOdel.Menu(menuItems, "Delete video");
            menuItems[value].Action();
        }
    }
}
