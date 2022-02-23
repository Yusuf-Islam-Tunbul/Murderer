using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murderer
{
    class Missile: RangedWeapon
    {
        public Missile(string name, int max_ammo, int power)
        {
            this.Name = name;
            this.ShootAct = " ile roket atıldı.";
            this.ReloadAct = " dolduruldu.";
            this.MaxAmmo = max_ammo;
            this.Ammo = max_ammo;
            this.Power = power;
        }

        public override Button CreateShootButton(string text)
        {
            Button shoot_butoon = base.CreateShootButton("Ateşle");

            return shoot_butoon;
        }


        public override Button CreateReloadButton(string text)
        {
            Button reload_butoon = base.CreateReloadButton("Roket Yerleştir");

            return reload_butoon;
        }
    }
}
