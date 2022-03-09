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
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace MetroLoader
{
    public partial class Register : MetroForm
    {

        StudentClass student = new StudentClass();
        public Register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
        

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }


        private void register_button1(object sender, EventArgs e)
        {
            // add new student
            string uname = metroTextBox1.Text;
            string pass = metroTextBox2.Text;


            if (student.useradd(uname, pass))
            {
                
   
                MessageBox.Show("User Registered", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 login = new Form1();
                this.Close();
                login.Show();


            }
           


        }

        
    }
}




    