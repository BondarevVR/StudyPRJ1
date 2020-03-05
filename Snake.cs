using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
// added some comment 
namespace ConsoleApp2
{
    class Snake
    { 
        public Snake(int pX, int pY)
        {
            SnakeX = pX;
            SnakeY = pY;
        }

        public int SnakeX { get; set; }
        public int SnakeY { get; set; }

        private int way;
        private ConsoleKeyInfo key;

        public void Turn()
        {

        }
    }
}
