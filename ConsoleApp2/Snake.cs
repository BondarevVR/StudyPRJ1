using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ConsoleApp2
{
    class Snake
    { 
        public Snake(int pX, int pY)
        {
            PositionX = pX;
            PositionY = pY;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        private int speed = 1;
        private string way = "right";
        ConsoleKeyInfo key;

        public void Turn()
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.A && way != "right")
            {
                way = "left";
                PositionX -= speed;
            }
            if (key.Key == ConsoleKey.D && way != "left")
            {
                way = "right";
                PositionX += speed;
            }
            if (key.Key == ConsoleKey.W && way != "down")
            {
                way = "up";
                PositionY -= speed;
            }
            if (key.Key == ConsoleKey.S && way != "up")
            {
                way = "down";
                PositionY += speed;
            }
        }
    }
}
