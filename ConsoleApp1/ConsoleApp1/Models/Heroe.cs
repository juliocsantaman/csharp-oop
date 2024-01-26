using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Heroe
    {
        public abstract string SaveTheWorld();

        public virtual string GreetingToTheWorld()
        {
            return "Greeting to the world!";
        }
    }
}
