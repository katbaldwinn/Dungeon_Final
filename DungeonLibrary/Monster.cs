using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //Make it public, make it a child of Character
     public class Monster : Character
     {
          //unique fields
          private int _minDamage;

          //unique props
          public int MaxDamage { get; set; }
          public string Description { get; set; }
          public int MinDamage
          {
               get { return _minDamage; }
               //custom business rule, value must be greater than 0 and less than MaxDamage.
               set
               {
                    if ((value > 0 && value < MaxDamage))
                    {
                         _minDamage = value;
                    }
                    else
                    {
                         _minDamage = 1;
                    }
               }
               //set { _minDamage = (value > 0 && value < MaxDamage) ? value : 1; }              
          }
          public bool IsBoss { get; set; }


          public Monster(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, bool isBoss) : base(name, hitChance, block, maxLife)
          {
               MaxDamage = maxDamage;
               Description = description;
               MinDamage = minDamage;
               IsBoss = isBoss;
          }

          public Monster()
          {

          }

          public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife)
          {
          }

          public override string ToString()
          {
               return $"\n********** MONSTER **********\n" +
                      base.ToString() +
                      $"Damage: {MinDamage} to {MaxDamage}\n" +
                      $"Description: {Description}";
          }

          public override int CalcDamage()
          {
               //throw new NotImplementedException();
               int result;//create the return object

               Random rand = new Random();//setup necessary resources

               result = rand.Next(MinDamage, MaxDamage + 1);//modify the return object

               return result;//return the return object
          }

          public static Monster GetMonster()
          {
               //create the return object
               Monster m = new();
               //setup necessary resources
               Monster m1 = new("Skeleton", 50, 20, 25, 2, 8, "Undead creatures equipped with rusty swords or bows. They're resilient but slow-moving", false);
               Monster m2 = new("Large Spider", 50, 15, 35, 4, 10, "Kind of touchy about their height; don't mention their cousin, 'Giant Spider'.", false);
               Monster m3 = new("Ghost", 60, 25, 25, 2, 6, "Intangible creatures that phase in and out of existence. They could possess special abilities, such as passing through walls or inflicting curses on the player.", false);
               Monster m4 = new("Wraith", 75, 50, 80, 7, 20, "Ethereal beings that drain the player's life force or abilities with their attacks. They could be resistant to physical attacks, requiring the player to find a specific way to defeat them.", true);
               Monster m5 = new("Dragon", 100, 50, 125, 10, 20, "Dragon", true);
               List<Monster> monsters = new()
            {
                m1, m1, m1, m1, m1,//5/17
                m2, m2, m2,        //3/17
                m3, m3, m3, m3,    //4/17
                m4, m4, m4, m4,    //4/17
                m5                 //1/17
            };
               Random rand = new Random();
               int randomIndex = rand.Next(monsters.Count);
               //modify the return object
               m = monsters[randomIndex];
               //return the return object
               return m;

               //refactor
               //return monsters[new Random().Next(monsters.Count)];
          }
     }
}
