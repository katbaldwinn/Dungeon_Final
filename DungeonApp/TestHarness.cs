using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonApp
{
    //a class used to test the different DungeonLibrary objects we've created
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //What you put in here is entirely up to you. You should attempt to create at least one of each custom datatype and test the functionality as we progress.
            //Nothing in here has any impact on the rest of the program. It's your playground for our new datatypes.
            //Character c1 = new Character("Name", 40, 5, 50);

            //Character c2 = new Character()
            //{
            //    Name = "New Name",
            //    HitChance = 0,
            //    Block = 2,
            //    MaxLife = 50,
            //    Life = 50
            //};
            //Monster m1 = new Monster("", 0, 0, 0, 0, 0, "");
            //Character c1 = m1;//polymorphism. BOXING - storing a monster as a character
            ////Console.WriteLine(c1);

            Monster monster = Monster.GetMonster();
            Console.WriteLine(monster);

            Weapon w1 = new Weapon("Stick", 1, 5, 1, false,WeaponType.Staff);
            Console.WriteLine();
            Player player = new Player("Player Name", 70, 15, 75, Race.Elf, w1);

            Console.WriteLine(player);
        }
    }
}
