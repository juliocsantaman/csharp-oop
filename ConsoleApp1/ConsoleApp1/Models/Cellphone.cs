using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Cellphone : Product, ICellphone
    {
        public Cellphone() 
        {
            Mark = "";
            Color = "";
        }

        public string On()
        {
            return "Cellphone is on";
        }

        public string Off()
        {
            return "Cellphone is off";
        }
    }
}
