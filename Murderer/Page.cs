using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murderer
{
    class Page
    {
        private Weapon _weapon;

        public Weapon Weapon
        {
            get
            {
                return _weapon;
            }

            set
            {
                _weapon= value;
            }
        }



        private List<Control> _controls;

        public List<Control> Controls
        {
            get
            {
                return _controls;
            }

            set
            {
                _controls = value;
            }
        }


        public Page(object weapon_)
        {
            if (weapon_.GetType().IsSubclassOf(typeof(ScopedWeapon)))
            {
                ScopedWeapon weapon = (ScopedWeapon)weapon_;
                this.Weapon = weapon;
                this.Controls = new List<Control>();
                this.Controls.Add(weapon.CreateShootButton(""));
                this.Controls.Add(weapon.CreateReloadButton(""));
                this.Controls.Add(weapon.CreateZoomInButton(""));
                this.Controls.Add(weapon.CreateZoomOutButton(""));
            }

            else if (weapon_.GetType().IsSubclassOf(typeof(RangedWeapon)))
            {
                RangedWeapon weapon = (RangedWeapon)weapon_;
                this.Weapon = weapon;
                this.Controls = new List<Control>();
                this.Controls.Add(weapon.CreateShootButton(""));
                this.Controls.Add(weapon.CreateReloadButton(""));
            }

            else if (weapon_.GetType().IsSubclassOf(typeof(MeleeWeapon)))
            {
                MeleeWeapon weapon = (MeleeWeapon)weapon_;
                this.Weapon = weapon;
                this.Controls = new List<Control>();
                this.Controls.Add(weapon.CreateShootButton(""));
                this.Controls.Add(weapon.CreateReloadButton(""));
            }

            else
            {
                throw new WeaponException("");
            }
        }

        //public Page(MeleeWeapon weapon)
        //{
        //    this.Weapon = weapon;
        //    this.Controls = new List<Control>();
        //    this.Controls.Add(weapon.CreateShootButton(""));
        //    this.Controls.Add(weapon.CreateReloadButton(""));
        //}

        //public Page(RangedWeapon weapon)
        //{
        //    this.Weapon = weapon;
        //    this.Controls = new List<Control>();
        //    this.Controls.Add(weapon.CreateShootButton(""));
        //    this.Controls.Add(weapon.CreateReloadButton(""));
        //}

        //public Page(ScopedWeapon weapon)
        //{
        //    this.Weapon = weapon;
        //    this.Controls = new List<Control>();
        //    this.Controls.Add(weapon.CreateShootButton(""));
        //    this.Controls.Add(weapon.CreateReloadButton(""));
        //    this.Controls.Add(weapon.CreateZoomInButton());
        //    this.Controls.Add(weapon.CreateZoomOutButton());
        //}


    }
}
