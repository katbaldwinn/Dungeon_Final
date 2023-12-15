using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //! Make it public, make it a child of Monster, Rename it to whatever you want
     public class Ghost : Monster
     {
          //FIELDS - only if you have business rules
          private bool _invisibility;

          //PROPS
          //! Add at least one custom property. 
          public bool Invisibility
          {
               get { return _invisibility; }
               set
               {
                    _invisibility = value;
                    if (_invisibility)
                    {
                         HitChance = 70;
                    }
                    else
                    {
                         HitChance = 60;
                    }
               }
          }

          //CTORS        
          public Ghost(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBoss, bool invisibility) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description, isBoss)
          {
               Invisibility = invisibility;
               //! Add your custom prop(s) to the parameter list and assign them here.
          }

          //! Default CTOR (creates a basic version of this monster)
          public Ghost()
          {
               //Assign each of the props some default value here
               //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
          }

          public override string ToString()
          {
               //! Update the ToString() to include your new prop
               return base.ToString() +
                       $"Can they turn invisible?: {Invisibility}";
          }

          //Override at least one parent method to change the functionality based on your custom prop
          //CalcBlock()
          //CalcHitChance()
          //CalcDamage()
     }
}
