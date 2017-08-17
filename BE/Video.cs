using ConsoleAppExcersices.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExcersices
{
    

    public class Video: MenuItem
    {
        public int Id { get; set; }
        public int size { get; }
        public int totalFrames { get; }
        private List<Actor> actors;
        
        //public string Content { get; set; }

        public Video(string name, int id) : base(name)
        {
            size = 20;
            totalFrames = 100;
            this.Id = id;
            actors = new List<Actor>();
        }

        //public string Name { get; set;}
        

        

        public override void Action()
        {
            PlayRecording();
        }

        public void StartRecording()
        {
            string[,] screen = new string[size,size];
            Actor player = new Actor('O');
            actors.Add(player);

            player.Frames.Add("1,5");

            bool running = true;
            int frame = 0;
            ConsoleKey keyPress = ConsoleKey.Z;//cant be null

            while(running)
            {
                if (frame != 0)
                {
                    MoveUnit(player, keyPress, size);
                }
                

                Console.Clear();
                InputScreen(screen,size);
                InputActors(frame,screen);
                
                
                DrawScreen(screen, size);

                Console.WriteLine("Frame:" + frame + ". Pos(" + player.Frames[frame] +")");

                keyPress = Console.ReadKey(true).Key;
                while (keyPress != ConsoleKey.DownArrow && keyPress != ConsoleKey.UpArrow && keyPress != ConsoleKey.LeftArrow && keyPress != ConsoleKey.RightArrow)
                {
                    keyPress = Console.ReadKey(true).Key;
                }
                
                frame++;
                if (frame > totalFrames)
                {
                    running = false;
                }

            }

        }

        private void MoveUnit(Actor actor,  ConsoleKey keyPress, int size)
        {
            string pos = actor.Frames[actor.Frames.Count-1];
            int currentX = int.Parse(pos.Substring(0, pos.IndexOf(",")));
            int currentY = int.Parse(pos.Substring(pos.IndexOf(",")+1, (pos.Length-1)-pos.IndexOf(",")));

            switch (keyPress)
            {
                case ConsoleKey.UpArrow:
                    if (currentY > 1)
                    {
                        currentY--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (currentY < size-2)
                    {
                        currentY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentX > 1)
                    {
                        currentX--;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (currentX < size - 2)
                    {
                        currentX++;
                    }
                    break;
                default:
                    break;
            }

            string newPos = currentX + "," + currentY;
            actor.Frames.Add(newPos);
        }

        private void InputActors(int frame, string[,] screen)
        {
            for (int i = 0; i < actors.Count; i++)
            {
                string pos = actors[i].Frames[frame];


                int x = int.Parse(pos.Substring(0, pos.IndexOf(",")));
                int y = int.Parse(pos.Substring(pos.IndexOf(",")+1, (pos.Length-1)-pos.IndexOf(",")));

                screen[x,y] = "" + actors[i].Tegn;
            }
        }

        private void InputScreen(string[,] screen, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1)
                    {
                        screen[i, j] = "-";
                    }
                    else if (i == 0 || i == size - 1)
                    {
                        screen[i, j] = "|";
                    }
                    else
                    {
                        screen[i, j] = " ";
                    }
                }
            }
        }

        private void DrawScreen(string[,] screen, int size)
        {
            for (int i = 0; i <size ; i++)
            {
                string line = "";
                for (int j = 0; j < size; j++)
                {
                    line += screen[j, i];
                }
                Console.WriteLine(line);
            }
        }

        public void PlayRecording()
        {
            string[,] screen = new string[size, size];


            for (int i = 0; i < totalFrames; i++)
            {
                Console.Clear();
                InputScreen(screen, size);
                InputActors(i, screen);
                DrawScreen(screen, size);

                System.Threading.Thread.Sleep(20);
            }
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}
