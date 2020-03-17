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
        public Food(int screenSizeX, int screenSizeY)
        {
            PositionX = rand.Next(1, screenSizeX - 1);
            PositionY = rand.Next(1, screenSizeY - 1);
            sizeX = screenSizeX;
            sizeY = screenSizeY;
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
