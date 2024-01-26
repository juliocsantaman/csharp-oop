using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
        public SuperHeroe()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        private string _Name;

        public int Id { get; set; }
        public string Name
        { 
            get { return _Name; }
            set { _Name = value.Trim(); }
        
        }

        public string NameAndSecretIdentity
        {
            get { return $"{Name} ({SecretIdentity})"; }
        }

        public string SecretIdentity { get; set; }
        public string City;
        public List<SuperPower> SuperPowers;
        public bool CanFly;

        public string UseSuperPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPowers)
            {
                sb.AppendLine($"{NameAndSecretIdentity} is using the super power {item.Name}");
            }

            return sb.ToString();
        }

        public override string SaveTheWorld()
        {
            return $"{SecretIdentity} have saved the world";
        }

        public override string GreetingToTheWorld()
        {
            return "Howdy, World!";
        }
    }
}
