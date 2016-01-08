using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Daniel";
            hero.Health = 100;
            hero.DamageMaximum = 10;
            hero.AttackBonus = 10;

            hero.Attack();
            //resultLabel.Text = 

            Character monster = new Character();
            monster.Name = "Creep";
            monster.Health = 100;
            monster.DamageMaximum = 10;
            monster.AttackBonus = 10;

            monster.Attack();
        }
    }
}
    