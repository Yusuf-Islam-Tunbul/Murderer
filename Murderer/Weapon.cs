using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Murderer
{
    abstract class Weapon
    {
        private string _name;
        private string _shoot_act;
        private string _reload_act;
        private int _max_ammo;
        private int _ammo;
        private int _power;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string ShootAct
        {
            get
            {
                return _shoot_act;
            }

            set
            {
                _shoot_act = value;
            }
        }

        public string ReloadAct
        {
            get
            {
                return _reload_act;
            }

            set
            {
                _reload_act = value;
            }
        }
        public int Ammo
        {
            get
            {
                return _ammo;
            }

            set
            {
                _ammo = value;
            }
        }

        public int MaxAmmo
        {
            get
            {
                return _max_ammo;
            }

            set
            {
                _max_ammo = value;
            }
        }

        public int Power
        {
            get
            {
                return _power;
            }

            set
            {
                _power= value;
            }
        }

        public virtual Button CreateShootButton(string text)
        {
            Button shoot_button = new Button();
            shoot_button.Size = new Size(70, 50);
            shoot_button.Top = 10;
            shoot_button.Left = 10;
            shoot_button.Text = text;
            shoot_button.Click+= new EventHandler(Shoot);
            return shoot_button;
        }

        public virtual Button CreateReloadButton(string text)
        {
            Button reload_button = new Button();
            reload_button.Size = new Size(70, 50);
            reload_button.Top = 10;
            reload_button.Left = 90;
            reload_button.Text = text;
            reload_button.Click += new EventHandler(Reload);
            return reload_button;
        }

        public void Shoot(object sender, EventArgs e)
        {
            if (this.Ammo > 0)
            {
                PlaySound(2);

                try
                {
                    Form1.enemy_progress_bar_.Value -= this.Power;
                }
                catch
                {
                    Form1.enemy_progress_bar_.Value = 0;
                }

                if (Form1.enemy_progress_bar_.Value <= 0)
                {
                    PlaySound(5);
                    Form1.enemy_progress_bar_.Value = Form1.enemy_progress_bar_.Maximum;
                }
                else
                {
                    PlaySound(3);
                }

                MessageBox.Show(this.Name + " " + this.ShootAct);
                this.Ammo--;

                Form1.ammo_label_.Text = this.Ammo.ToString();
                Form1.ammo_progress_bar_.Value--;


                
            }

            else
            {
                PlaySound(4);
                MessageBox.Show("Mühimmat yenileyiniz.");
            }
        }

        public void Reload(object sender, EventArgs e)
        {
            if ((this.Ammo < this.MaxAmmo)||this.Ammo>1000)
            {
                PlaySound(1);

                this.Ammo = this.MaxAmmo;
                Form1.ammo_label_.Text = this.Ammo.ToString();
                Form1.ammo_progress_bar_.Value = Form1.ammo_progress_bar_.Maximum;
                MessageBox.Show(this.Name + " " + this.ReloadAct);
            }
            else
            {
                MessageBox.Show("Zaten dolu.");
            }
        }

        void PlaySound(int sound)
        {
            System.Threading.Thread.Sleep(500);
            try
            {
                switch (sound)
                {
                    case 1:
                        PlaySound1();
                        break;
                    case 2:
                        PlaySound2();
                        break;
                    case 3:
                        PlaySound3();
                        break;
                    case 4:
                        PlaySound4();
                        break;
                    case 5:
                        PlaySound5();
                        break;
                }

            }

            catch
            {

            }
        }

        void PlaySound1()
        {
            SoundPlayer sound_player = new SoundPlayer(Directory.GetCurrentDirectory() + @"\Reload\" + this.Name + ".wav");

            sound_player.Play();
        }

        void PlaySound2()
        {
            SoundPlayer sound_player = new SoundPlayer(Directory.GetCurrentDirectory() + @"\Shoot\" + this.Name + ".wav");

            sound_player.Play();
        }

        void PlaySound3()
        {
            SoundPlayer sound_player = new SoundPlayer(Directory.GetCurrentDirectory() + @"\Wounded.wav");
            sound_player.Play();
        }

        void PlaySound4()
        {
            SoundPlayer sound_player = new SoundPlayer(Directory.GetCurrentDirectory() + @"\Empty\" + this.Name + ".wav");

            sound_player.Play();
        }

        void PlaySound5()
        {
            SoundPlayer sound_player = new SoundPlayer(Directory.GetCurrentDirectory() + @"\Dead.wav");
            sound_player.Play();
        }
    }
}
