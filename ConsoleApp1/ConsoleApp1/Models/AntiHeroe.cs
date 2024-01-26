using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string AntiHeroeDoAnAction(string action)
        {
            return $"The AntiHeroe {Name} ({SecretIdentity}) have done: {action}";
        }
    }
}
