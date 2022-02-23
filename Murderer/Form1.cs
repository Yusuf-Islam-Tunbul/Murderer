using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Murderer
{
    public partial class Form1 : Form
    {
        List<Keys> keys;
        List<Page> pages;
        public static Label ammo_label_;
        public static ProgressBar ammo_progress_bar_;
        public static ProgressBar enemy_progress_bar_;
        
        public Form1()
        {
            InitializeComponent();

            ammo_label_ = ammo_label;
            ammo_progress_bar_ = ammo_progressbar;
            ammo_progressbar.Maximum = 20;
            enemy_progress_bar_ = enemy_progressbar;

            enemy_progressbar.Maximum = 100;
            enemy_progressbar.Value = 100;

            AddPages();
            AddKeys();            

            this.KeyPreview = true;

            StartPage(0);
        }

        void AddPages()
        {
            pages = new List<Page>();
            pages.Add(new Page(new Dagger("Kama", 10)));
            pages.Add(new Page(new Pistol("Tabanca", 6, 25)));
            pages.Add(new Page(new AK_47("AK-47", 30, 50)));
            pages.Add(new Page(new Shotgun("Pompalı Tüfek", 1, 35)));
            pages.Add(new Page(new RPG("RPG", 1, 100)));
            pages.Add(new Page(new Missile("Roket Atar", 1, 100)));
        }

        void AddKeys()
        {
            keys = new List<Keys>();
            keys.Add(Keys.D1);
            keys.Add(Keys.D2);
            keys.Add(Keys.D3);
            keys.Add(Keys.D4);
            keys.Add(Keys.D5);
            keys.Add(Keys.D6);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChangePage(e);
        }

        void StartPage(int index)
        {
            button_panel.Controls.Clear();

            Page page = pages[index];
            Weapon weapon = page.Weapon;

            if (weapon is MeleeWeapon)
            {
                ammo_label.Text = "--";
                ammo_progressbar.Maximum = weapon.MaxAmmo;
                ammo_progressbar.Value = weapon.Ammo;
            }

            else
            {
                ammo_label.Text = weapon.Ammo.ToString();
                ammo_progressbar.Maximum = weapon.MaxAmmo;
                ammo_progressbar.Value = weapon.Ammo;
            }


            foreach (Control control in page.Controls)
            {
                button_panel.Controls.Add(control);
            }

            this.Text = page.Weapon.Name;

            try
            {
                picturebox.ImageLocation = Directory.GetCurrentDirectory() + @"\Pictures\" + page.Weapon.Name + ".jpg";
            }

            catch
            {

            }

        }


        void ChangePage(KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;


            if (keys.Contains(key))
            {
                button_panel.Controls.Clear();

                int index = keys.IndexOf(key);
                Page page = pages[index];
                Weapon weapon = page.Weapon;

                if (weapon is MeleeWeapon)
                {
                    ammo_label.Text = "--";
                    ammo_progressbar.Maximum = weapon.MaxAmmo;
                    ammo_progressbar.Value = weapon.Ammo;
                }

                else
                {
                    ammo_label.Text = weapon.Ammo.ToString();
                    ammo_progressbar.Maximum = weapon.MaxAmmo;
                    ammo_progressbar.Value = weapon.Ammo;
                }


                foreach (Control control in page.Controls)
                {
                    button_panel.Controls.Add(control);
                }

                this.Text = page.Weapon.Name;

                try
                {
                    picturebox.ImageLocation = Directory.GetCurrentDirectory() + @"\Pictures\" + page.Weapon.Name + ".jpg";
                }

                catch
                {

                }
            }
        }

        private void ammo_label_TextChanged(object sender, EventArgs e)
        {
            UpdateAmmo();
        }

        void UpdateAmmo()
        {
            try
            {
                if (Convert.ToInt32(ammo_label.Text) > 1000)
                {
                    ammo_label.Text = "--";
                    ammo_progressbar.Value=ammo_progressbar.Maximum;
                }
            }

            catch
            {

            }
            
        }
    }
}
