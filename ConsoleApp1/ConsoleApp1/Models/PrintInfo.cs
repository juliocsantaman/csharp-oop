using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class PrintInfo
    {
        public void PrintSuperHeroe(ISuperHeroe superHeroe) 
        {
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Name: {superHeroe.Name}");
            Console.WriteLine($"SecretIdentity: {superHeroe.SecretIdentity}");
        }

        public void PrintCellphoneInfo(ICellphone cellphone)
        {
            Console.WriteLine("********** Cellphone info **********");
            Console.WriteLine($"Mark: {cellphone.Mark}");
            Console.WriteLine($"Color: {cellphone.Color}");
        }
    }
}
