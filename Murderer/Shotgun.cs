using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murderer
{
    class Shotgun: RangedWeapon
    {
        public Shotgun(string name, int max_ammo, int power)
        {
            this.Name = name;
            this.ShootAct = " ile ateş edildi.";
            this.ReloadAct = " dolduruldu.";
            this.MaxAmmo = max_ammo;
            this.Ammo = max_ammo;
            this.Power = power;
        }

        public override Button CreateShootButton(string text)
        {
            Button shoot_butoon = base.CreateShootButton("Ateş Et");

            return shoot_butoon;
        }


        public override Button CreateReloadButton(string text)
        {
            Button reload_butoon = base.CreateReloadButton("Fişek Yerleştir");

            return reload_butoon;
        }
    }
}
