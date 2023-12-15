using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //make it public, make it a child of character
     //Character includes Name, HitChance, Block, Life and MaxLife
     public class Player : Character
     {

          //Fields - none
          //Properties
          public Race PlayerRace { get; set; }
          public Weapon EquippedWeapon { get; set; } //CONTAINMENT
          public int Score { get; set; }

          //Constructors
          public Player(string name, int hitChance, int block, int maxLife, Race playerRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife)
          {
               PlayerRace = playerRace;
               EquippedWeapon = equippedWeapon;

               #region Potential Expansion: Racial Bonuses
               switch (PlayerRace)
               {
                    case Race.Human:
                         MaxLife += 3;
                         Life = MaxLife;
                         break;
                    case Race.Elf:
                         HitChance += 5;
                         break;
                    default:
                         break;
               }
               #endregion
          }

          public Player()
          {
          }



          //Methods
          public override string ToString()
          {
               //A description for the race:
               string description;
               switch (PlayerRace)
               {
                    case Race.Human:
                         description = "Boring, basic human. Probably snores.";
                         break;
                    case Race.Elf:
                         description = "A little big for Santa's workshop...";
                         break;
                    case Race.Dwarf:
                         description = "Strong and stubborn";
                         break;
                    case Race.Wizard:
                         description = "Humans with magic. Still snores";
                         break;
                    case Race.Hobbit:
                         description = "Small humans that do not snore. But have nothing but resilience.";
                         break;
                    default:
                         description = "Somehow, this being has no discernable race...";
                         break;
               }

               //add the weapon and the description to the base.ToString()
               return base.ToString() + $"Weapon:\t{EquippedWeapon}\n" +
                                        $"Description: {description}\n" +
                                        $"You have defeated {Score} monster(s)";
          }//end ToString()

          //override CalcHitChance/CalcDamage... 
          public override int CalcDamage()
          {
               //create the return object
               int result;
               //setup necessary resources
               Random rand = new Random();
               //modify the return object
               int minDamage = EquippedWeapon.MinDamage;
               int maxDamage = EquippedWeapon.MaxDamage;
               if (EquippedWeapon.Type == WeaponType.Bow && PlayerRace == Race.Elf)
               {
                    minDamage += 3;
                    maxDamage += 5;
               }
               result = rand.Next(minDamage, maxDamage + 1);
               //return the return object
               return result;

               //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
          }

          public override int CalcHitChance()
          {
               return HitChance + EquippedWeapon.BonusHitChance;
          }



          public static Player GetPlayer()
          {
               Player p = new();

               Player player1 = new("Eirian", 70, 10, 60, Race.Elf, Weapon.GetWeapon());
               Player player5 = new("Bob", 60, 5, 30, Race.Human, Weapon.GetWeapon());
               Player player2 = new("Baldur Stonehammer", 75, 15, 40, Race.Dwarf, Weapon.GetWeapon());
               Player player3 = new("Nyx Arcanum", 70, 20, 70, Race.Wizard, Weapon.GetWeapon());
               Player player4 = new("Pearl Goodbody", 80, 5, 40, Race.Hobbit, Weapon.GetWeapon());

               List<Player> players = new()
               {
                    player1, player1, player1, player1, player1,
                    player3, player3,
                    player5, player5, player5,
                    player2, player2, player2, player2,
                    player4
               };
               Random rand = new Random();
               int randomIndex = rand.Next(players.Count);
               //modify the return object
               p = players[randomIndex];
               //return the return object
               return p;
          }
     }
}
