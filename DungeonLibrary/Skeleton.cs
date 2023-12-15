using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DungeonLibrary
{
     //! Make it public, make it a child of Monster, Rename it to whatever you want
     public class Skeleton : Monster
     {
          //FIELDS - only if you have business rules
          private bool _hasCalcium;

          //PROPS
          //! Add at least one custom property. 
          public bool HasCalcium
          {
               get { return _hasCalcium; }
               set
               {
                    _hasCalcium = value; // Assign the incoming value to the private field
                    if (_hasCalcium) // Check the value being set
                    {
                         HitChance = 50; // Set HitChance when HasCalcium is true
                    }
                    else
                    {
                         HitChance = 25; // Set HitChance when HasCalcium is false
                    }
               }
          }

          //CTORS        
          public Skeleton(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBoss, bool hasCalcium) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description, isBoss)
          {
               HasCalcium = hasCalcium;
               //! Add your custom prop(s) to the parameter list and assign them here.
          }

          //! Default CTOR (creates a basic version of this monster)
          public Skeleton()
          {
               //Assign each of the props some default value here
               //Name, HitChance, Block, MaxLife, MaxDamage, MinDamage, Description
          }

          public override string ToString()
          {
               //! Update the ToString() to include your new prop
               return base.ToString() +
                    $"Did they drink calcium?: {HasCalcium}\n";
          }

          //Override at least one parent method to change the functionality based on your custom prop
          //CalcBlock()
          //CalcHitChance()
          //CalcDamage()
     }
}
