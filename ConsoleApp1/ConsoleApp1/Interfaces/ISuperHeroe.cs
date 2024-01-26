using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Name { get; set; }
        string SecretIdentity { get; set; }
    }
}
