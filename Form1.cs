using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Tax_All
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
            
            userControlGroup21.BringToFront();
            userControlGroup31.BringToFront();
            userControlGroup41.BringToFront();
            userControlGroup11.BringToFront();
            userControlGroup51.BringToFront();
            home1.BringToFront();

        }
        private void CustomizeDesing()
        {
            panelGroup5.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelGroup5.Visible == true)
                panelGroup5.Visible = false; 
        }

        private void ShowSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControlGroup21.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControlGroup11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControlGroup31.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();//ออกจากโปรแกรม
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControlGroup41.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelGroup5);
            userControlGroup51.BringToFront();
        }

        private void btGroup5_Click(object sender, EventArgs e)
        {
            userControlGroupTown1.BringToFront();
            HideSubMenu();
        }
    }
}
