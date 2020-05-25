using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Home());
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int Bn = int.Parse(textBox2.Text);
            int etc = int.Parse(textBox3.Text);
            int oc;
            oc = (month * 12) + Bn + etc;
            textBox4.Text = oc.ToString();
        }

        private void bt_sent_Click(object sender, EventArgs e)
        {
            Group1 tax = new Group1();
            tax.textBoxPungpamern01.Text = textBox4.Text;
            tax.Show();
            this.Hide();
        }
    }
}
