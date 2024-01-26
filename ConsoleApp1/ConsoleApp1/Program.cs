// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;
using ConsoleApp1.Models;

PrintInfo printInfo = new PrintInfo();

// COMPUTERS.
Computer computerDell = new Computer("Dell", 15, 15, "Black", false);
Computer computerAsus = new Computer("Asus", 17, 17, "Red", true);

Console.WriteLine(computerDell.Mark);
Console.WriteLine(computerAsus.Mark);
// END OF COMPUTERS.

// CELLPHONES.
Cellphone c1 = new Cellphone();
c1.Mark = "iPhone 15";
c1.Color = "Black";

printInfo.PrintCellphoneInfo(c1);
Console.WriteLine(c1.On());
Console.WriteLine(c1.Off());
// END OF CELLPHONES.

// SuperPowers.
SuperPower fly = new SuperPower();

fly.Name = "Fly";
fly.Description = "Capacity to fly in the air.";
fly.Level = PowerLevel.Level2;

SuperPower strong = new SuperPower();

strong.Name = "Strong";
strong.Description = "Capacity to fight and doing a lot of damage.";
strong.Level = PowerLevel.Level3;

SuperPower regeneration = new SuperPower();
regeneration.Name = "Regeneration";
regeneration.Description = "Capacity to have a lot of health";
regeneration.Level = PowerLevel.Level3;
// End of SuperPowers.

// SuperHeroes.
SuperHeroe silverSurfer = new SuperHeroe();

silverSurfer.Id= 1;
silverSurfer.Name = "Batman";
silverSurfer.SecretIdentity = "Juuz";
silverSurfer.City = "Cancún";
silverSurfer.CanFly = true;

SuperHeroe silverSurfer2 = new SuperHeroe();

silverSurfer2.Id = 1;
silverSurfer2.Name = "Batman";
silverSurfer2.SecretIdentity = "Juuz";
silverSurfer2.City = "Cancún";
silverSurfer2.CanFly = true;

Console.WriteLine(silverSurfer == silverSurfer2);

List<SuperPower> silverSurferSuperPowers = new List<SuperPower>();
silverSurferSuperPowers.Add(fly);
silverSurferSuperPowers.Add(strong);

silverSurfer.SuperPowers = silverSurferSuperPowers;
Console.WriteLine(silverSurfer.UseSuperPower());
// End of SuperHeroes.

/* RECORD */
SuperHeroeRecord silverSurferRecord = new SuperHeroeRecord(1, "Batman", "Juuz");
SuperHeroeRecord silverSurferRecord2 = new SuperHeroeRecord(1, "Batman", "Juuz");

Console.WriteLine(silverSurferRecord == silverSurferRecord2);
/* END OF RECORD*/

// ANTIHEROE.
AntiHeroe deadpool = new AntiHeroe();
deadpool.Id = 1;
deadpool.Name = "Julio";
deadpool.SecretIdentity = "Deadpool";
deadpool.City = "New York";
deadpool.CanFly = false;

List<SuperPower> deadpoolSuperPowers= new List<SuperPower>();
deadpoolSuperPowers.Add(regeneration);

deadpool.SuperPowers = deadpoolSuperPowers;

Console.WriteLine(deadpool.UseSuperPower());
Console.WriteLine(deadpool.AntiHeroeDoAnAction("shoot to the enemies"));
Console.WriteLine(deadpool.GreetingToTheWorld());

printInfo.PrintSuperHeroe(deadpool);

// END OF ANTIHEROE.

enum PowerLevel
{
    Level1,
    Level2,
    Level3
}

public record SuperHeroeRecord(int Id, string Name, string SecretIdentity);

