using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MetroFramework.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroLoader
{
    public partial class Mainform : MetroForm
    {
        StudentClass student = new StudentClass();
        
        public Mainform()
        {
            InitializeComponent();
            customizeDesign();
        }

      

        //create a function to display student count
        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();

        }


        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
           

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region StdSubmenu
        private void button_registration_Click(object sender, EventArgs e)
        {
            //openChildForm(new RegisterForm());
            //...
            //..Your code
            //...
            //hideSubmenu();

            




                RegisterForm registerform1 = new RegisterForm();
                this.Hide();
                registerform1.Show();



           

        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
           // openChildForm(new ManageStudentForm());
            //...
            //..Your code
            //...
           // hideSubmenu();


            ManageStudentForm man = new ManageStudentForm();
            this.Hide();
            man.Show(); 
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            //...
            //..Your code
            //...
            hideSubmenu();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
            //populate the combobox with courses name
           
           
        }

        #endregion StdSubmenu
        
       

       

       

     

        //to show register form in mainform
       
      

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
