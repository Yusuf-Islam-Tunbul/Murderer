using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murderer
{
    class RPG: ScopedWeapon
    {
        public RPG(string name, int max_ammo, int power)
        {
            this.Name = name;
            this.ShootAct = " ile roket atıldı.";
            this.ReloadAct = " dolduruldu.";
            this.ZoomInAct = "Yakınlaştırıldı.";
            this.ZoomOutAct = "Uzaklaştırıldı.";
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

        public override Button CreateZoomInButton(string text)
        {
            Button zoom_in_button = base.CreateZoomInButton("Yakınlaştır");

            return zoom_in_button;
        }

        public override Button CreateZoomOutButton(string text)
        {
            Button zoom_in_button = base.CreateZoomOutButton("Uzaklaştır");

            return zoom_in_button;
        }
    }
}
