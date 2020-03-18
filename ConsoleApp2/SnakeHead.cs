using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class SnakeHead : SnakePart
    {
        public SnakeHead() { }
        public SnakeHead(int pX, int pY, int screenSizeX, int screenSizeY):base(pX, pY, screenSizeX, screenSizeY) { }

        private const int speed = 1;

        private enum Way
        {
            Left,
            Right,
            Up,
            Down
        }
        private Way way = Way.Right;

        ConsoleKeyInfo key;

        public void Turn()
        {
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.A && way != Way.Right && PositionX > 0)
            {
                way = Way.Left;
                PositionX -= speed;
            }
            if (key.Key == ConsoleKey.D && way != Way.Left && PositionX < sizeX)
            {
                way = Way.Right;
                PositionX += speed;
            }
            if (key.Key == ConsoleKey.W && way != Way.Down && PositionY > 0)
            {
                way = Way.Up;
                PositionY -= speed;
            }
            if (key.Key == ConsoleKey.S && way != Way.Up && PositionY < sizeY + 1)
            {
                way = Way.Down;
                PositionY += speed;
            }
        }

        public bool CheckTouch(Object obj)
        {
            if (obj is SnakePart)
            {
                SnakePart snake;
                snake = (SnakePart)obj;
                if (PositionX == snake.PositionX && PositionY == snake.PositionY)
                    return true;
                return false;
            }
            else if (obj is Screen)
            {
                Screen screen;
                screen = (Screen)obj;
                if (PositionX == screen.SizeX || PositionX == 0 || PositionY == 0 || PositionY == screen.SizeY + 1)
                    return true;
                return false;
            }
            else if (obj is Food)
            {
                Food food;
                food = (Food)obj;
                if (PositionX == food.PositionX && PositionY == food.PositionY)
                    return true;
                return false;
            }
            else
            {
                Console.WriteLine("Error object");
                return false;
            }
        }
    }
}

