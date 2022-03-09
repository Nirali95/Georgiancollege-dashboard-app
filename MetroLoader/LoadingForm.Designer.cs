namespace MetroLoader
{
    partial class LoadingForm
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
            MetroFramework.Controls.MetroProgressBar metroProgressBar1;
            Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroProgressBar1
            // 
            metroProgressBar1.Location = new System.Drawing.Point(71, 280);
            metroProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            metroProgressBar1.MarqueeAnimationSpeed = 1000;
            metroProgressBar1.Name = "metroProgressBar1";
            metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            metroProgressBar1.Size = new System.Drawing.Size(470, 23);
            metroProgressBar1.TabIndex = 2;
            metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            guna2PictureBox1.BorderRadius = 10;
            guna2PictureBox1.Enabled = false;
            guna2PictureBox1.Image = global::Georgian.Properties.Resources.Georgian_College_logo_svg;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new System.Drawing.Point(71, 106);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.Size = new System.Drawing.Size(470, 118);
            guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(608, 360);
            this.Controls.Add(metroProgressBar1);
            this.Controls.Add(guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadingForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "LOADING | PLEASE WAIT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Timer timer1;
    }
}