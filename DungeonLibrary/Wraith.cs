using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //! Make it public, make it a child of Monster, Rename it to whatever you want
     public class Wraith : Monster
     {
          //FIELDS - only if you have business rules
          private bool _isScary;

          //PROPS
          //! Add at least one custom property. 
          public bool IsScary 
          {
               get { return _isScary; }
               set
               {
                    _isScary = value;
                    if (_isScary)
                    {
                         HitChance = 100;
                    }
                    else
                    {
                         HitChance = 75;
                    }
               } 
          } // Custom property for boss designation

          //CTORS        
          public Wraith(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBoss, bool isScary) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description, isBoss)
          {
               IsScary = isScary;
               //! Add your custom prop(s) to the parameter list and assign them here.
          }

          //! Default CTOR (creates a basic version of this monster)
          public Wraith()
          {
               //Assign each of the props some default value here
               //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
          }

          public override string ToString()
          {
               //! Update the ToString() to include your new prop
               return base.ToString() + 
                    $"Are they scary?: {IsScary}";
          }

          //Override at least one parent method to change the functionality based on your custom prop
          //CalcBlock()
          //CalcHitChance()
          //CalcDamage()
     }
}
