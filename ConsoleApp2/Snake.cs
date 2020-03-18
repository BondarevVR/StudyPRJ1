using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
 
namespace ConsoleApp2
{
    class SnakePart
    {
        protected int sizeX;
        protected int sizeY;
        public SnakePart() { }
        public SnakePart(int pX, int pY, int screenSizeX, int screenSizeY)
        {
            PositionX = pX;
            PositionY = pY;
            sizeX = screenSizeX;
            sizeY = screenSizeY;
        }

        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }

        public void SetPosition(SnakePart nextSnakePart)
        {
            PositionX = nextSnakePart.PositionX;
            PositionY = nextSnakePart.PositionY;
        }
    }
}
