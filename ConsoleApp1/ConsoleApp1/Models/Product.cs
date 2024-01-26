using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product
    {
        string mark;
        double width;
        double height;
        string color;

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
