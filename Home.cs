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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
            
        }
    }
}
