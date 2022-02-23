using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murderer
{
    abstract class MeleeWeapon: Weapon
    {
        public MeleeWeapon()
        {

        }

        public MeleeWeapon(string name,int power)
        {
            this.Name = name;
            this.ShootAct = " savruldu.";
            this.ReloadAct = " bileylendi.";
            this.MaxAmmo = int.MaxValue;
            this.Ammo = int.MaxValue;
            this.Power = power;
            Form1.ammo_label_.Text = "--";
        }

        public override Button CreateShootButton(string text)
        {
            Button shoot_butoon = base.CreateShootButton("Savur");

            return shoot_butoon;
        }


        public override Button CreateReloadButton(string text)
        {
            Button reload_butoon = base.CreateReloadButton("Bileyle");

            return reload_butoon;
        }
    }
}
