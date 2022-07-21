using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_pro.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
        }
        
        public override string Attack()
        {
        return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name = " Lançou Magia super efetiva com bonus de " + Bonus;
            }else 
            {
                return this.Name = " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}