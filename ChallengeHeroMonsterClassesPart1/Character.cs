using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClassesPart1
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }
        

        public int Attack()
        {
            Random attack = new Random();
            int damage = attack.Next(1, 10);
            Health -= damage;
            return Health;
        }

        public int Defend(int damage)
        {
            DamageMaximum += damage;
            return DamageMaximum;
        }
    }
}