namespace Murderer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_panel = new System.Windows.Forms.Panel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.ammo_progressbar = new System.Windows.Forms.ProgressBar();
            this.ammo_label = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enemy_progressbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_panel
            // 
            this.button_panel.Location = new System.Drawing.Point(16, 15);
            this.button_panel.Margin = new System.Windows.Forms.Padding(4);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(267, 166);
            this.button_panel.TabIndex = 0;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(291, 15);
            this.picturebox.Margin = new System.Windows.Forms.Padding(4);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(267, 246);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            // 
            // ammo_progressbar
            // 
            this.ammo_progressbar.Location = new System.Drawing.Point(29, 188);
            this.ammo_progressbar.Margin = new System.Windows.Forms.Padding(4);
            this.ammo_progressbar.Name = "ammo_progressbar";
            this.ammo_progressbar.Size = new System.Drawing.Size(133, 28);
            this.ammo_progressbar.TabIndex = 2;
            // 
            // ammo_label
            // 
            this.ammo_label.AutoSize = true;
            this.ammo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ammo_label.Location = new System.Drawing.Point(171, 188);
            this.ammo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ammo_label.Name = "ammo_label";
            this.ammo_label.Size = new System.Drawing.Size(26, 29);
            this.ammo_label.TabIndex = 3;
            this.ammo_label.Text = "0";
            this.ammo_label.TextChanged += new System.EventHandler(this.ammo_label_TextChanged);
            // 
            // enemy_progressbar
            // 
            this.enemy_progressbar.Location = new System.Drawing.Point(29, 224);
            this.enemy_progressbar.Margin = new System.Windows.Forms.Padding(4);
            this.enemy_progressbar.Name = "enemy_progressbar";
            this.enemy_progressbar.Size = new System.Drawing.Size(133, 28);
            this.enemy_progressbar.TabIndex = 4;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.enemy_progressbar);
            this.Controls.Add(this.ammo_label);
            this.Controls.Add(this.ammo_progressbar);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.button_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.ProgressBar ammo_progressbar;
        private System.Windows.Forms.Label ammo_label;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ProgressBar enemy_progressbar;
    }
}

