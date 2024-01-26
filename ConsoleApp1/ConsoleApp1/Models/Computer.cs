using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Computer : Product
    {
        bool isGamer;

        public Computer(string mark, double width, double height, string color, bool isGamer)
        {
            Mark = mark;
            Width = width;
            Height = height;
            Color = color;
            IsGamer = isGamer;
        }

        public bool IsGamer
        {
            get { return isGamer; }
            set { isGamer = value; }
        }

   
    }
}
