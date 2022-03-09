using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroLoader
{
    public partial class LoadingForm :  MetroForm
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            
            if (startpoint > 50)
            {
                
                Form1 login = new Form1();
            

                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
