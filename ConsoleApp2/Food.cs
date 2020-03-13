using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Food
    {
        private Random rand = new Random();
        private int sizeX;
        private int sizeY;
        public Food(int ScreenSizeX, int ScreenSizeY)
        {
            PositionX = rand.Next(1, ScreenSizeX - 1);
            PositionY = rand.Next(1, ScreenSizeY - 1);
            sizeX = ScreenSizeX;
            sizeY = ScreenSizeY;
        }

        public int  PositionX { get; private set; }
        public int PositionY { get; private set; }

        public void NewPozition()
        {
            PositionX = rand.Next(1, sizeX - 1);
            PositionY = rand.Next(1, sizeY - 1);
        }
    }
}
