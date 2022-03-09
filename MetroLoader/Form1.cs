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

/*
 * Size: 355, 237
 * Style: Red
 * Theme: Light
 */

namespace MetroLoader
{
    public partial class Form1 : MetroForm
    {
       
        StudentClass student = new StudentClass();

        public Form1()
        {
            InitializeComponent();
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void button_login_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = metroTextBox1.Text;
                string pass = metroTextBox2.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    Mainform main = new Mainform();
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void register_button(object sender, EventArgs e)
        {
            
           
                

                    Register reg = new Register();
                    this.Hide();
                    reg.Show();

               

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}

