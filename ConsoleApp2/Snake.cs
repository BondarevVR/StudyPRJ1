﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ConsoleApp2
{
    class Snake
    {
        private int sizeX;
        private int sizeY;
        public Snake(int pX, int pY, int ScreenSizeX, int ScreenSizeY)
        {
            PositionX = pX;
            PositionY = pY;
            sizeX = ScreenSizeX;
            sizeY = ScreenSizeY;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        private int speed = 1;
        private string way = "right";
        ConsoleKeyInfo key;

        public void SetPosition(Snake nextSnakePart)
        {
            PositionX = nextSnakePart.PositionX;
            PositionY = nextSnakePart.PositionY;
        }

        public void Turn()
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.A && way != "right" && PositionX > 0)
            {
                way = "left";
                PositionX -= speed;
            }
            if (key.Key == ConsoleKey.D && way != "left" && PositionX < sizeX)
            {
                way = "right";
                PositionX += speed;
            }
            if (key.Key == ConsoleKey.W && way != "down" && PositionY > 0 )
            {
                way = "up";
                PositionY -= speed;
            }
            if (key.Key == ConsoleKey.S && way != "up" && PositionY < sizeY)
            {
                way = "down";
                PositionY += speed;
            }
        }

        public bool CheckTouch(Object obj)
        {
            if (obj is Snake)
            {
                Snake snake;
                snake = (Snake)obj;
                if (PositionX == snake.PositionX && PositionY == snake.PositionY)
                {
                    return true;
                }
                else { return false; }
            }
            else if (obj is Screen)
            {
                Screen screen;
                screen = (Screen)obj;
                if (PositionX == screen.SizeX || PositionX == 0 || PositionY == 0 || PositionY == screen.SizeY)
                {
                    return true;
                }
                else { return false; }
            }
            else if (obj is Food)
            {
                Food food;
                food = (Food)obj;
                if (PositionX == food.PositionX && PositionY == food.PositionY)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                Console.WriteLine("Error object");
                return false;
            }
        }
    }
}
