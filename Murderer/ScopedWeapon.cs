using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Murderer
{
    abstract class ScopedWeapon : RangedWeapon
    {
        private string _zoom_in_act;
        private string _zoom_out_act;

        public string ZoomInAct
        {
            get
            {
                return _zoom_in_act;
            }

            set
            {
                _zoom_in_act = value;
            }
        }

        public string ZoomOutAct
        {
            get
            {
                return _zoom_out_act;
            }

            set
            {
                _zoom_out_act = value;
            }
        }


        public ScopedWeapon()
        {

        }

        public ScopedWeapon(string name,int max_ammo,int power)
        {
            this.Name = name;
            this.ShootAct = " ile ateş edildi.";
            this.ReloadAct = " dolduruldu.";
            
        }

        public virtual Button CreateZoomInButton(string text)
        {
            Button zoom_in_button = new Button();
            zoom_in_button.Size = new Size(70, 50);
            zoom_in_button.Top = 70;
            zoom_in_button.Left = 10;
            zoom_in_button.Text = text;
            zoom_in_button.Click += new EventHandler(ZoomIn);
            return zoom_in_button;
        }

        public virtual Button CreateZoomOutButton(string text)
        {
            Button zoom_out_button = new Button();
            zoom_out_button.Size = new Size(70, 50);
            zoom_out_button.Top = 70;
            zoom_out_button.Left = 90;
            zoom_out_button.Text = text;
            zoom_out_button.Click += new EventHandler(ZoomOut);

            return zoom_out_button;
        }

        void ZoomIn(object sender, EventArgs e)
        {
            MessageBox.Show(ZoomInAct);
        }

        void ZoomOut(object sender, EventArgs e)
        {
            MessageBox.Show(ZoomOutAct);
        }
    }
}
