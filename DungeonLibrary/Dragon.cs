using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //! Make it public, make it a child of Monster, Rename it to whatever you want
     public class Dragon : Monster
     {
          //FIELDS - only if you have business rules
          private bool _isWinged;

          //PROPS
          //! Add at least one custom property. 
          public bool IsWinged 
          {
               get { return _isWinged; }
               set
               {
                    _isWinged = value;
                    if (_isWinged)
                    {
                         HitChance = 125;
                    }
                    else
                    {
                         HitChance = 100;
                    }
               } 
          }

          //CTORS        
          public Dragon(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBoss, bool isWinged) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description, isBoss)
          {
               IsWinged = isWinged;
               //! Add your custom prop(s) to the parameter list and assign them here.
          }

          //! Default CTOR (creates a basic version of this monster)
          public Dragon()
          {
               //Assign each of the props some default value here
               //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
          }

          public override string ToString()
          {
               //! Update the ToString() to include your new prop
               return base.ToString() + 
                    $"If he is winged, good luck catching him!: {IsWinged}";
          }

          //Override at least one parent method to change the functionality based on your custom prop
          //CalcBlock()
          //CalcHitChance()
          //CalcDamage()
     }
}
