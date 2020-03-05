using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Food
    {
        Random rand = new Random();
        private int SizeX;
        private int SizeY;
        public Food(int ScreenSizeX, int ScreenSizeY)
        {
            PositionX = rand.Next(1, ScreenSizeX - 1);
            PositionY = rand.Next(1, ScreenSizeY - 1);
            SizeX = ScreenSizeX;
            SizeY = ScreenSizeY;
        }

        public int  PositionX { get; set; }
        public int PositionY { get; set; }

        public void NewPozition()
        {
            PositionX = rand.Next(1, SizeX - 1);
            PositionY = rand.Next(1, SizeY - 1);
        }
    }
}
