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
    public partial class Group5 : Form
    {
        public Group5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ลดหย่อนภาษี
            int shop = int.Parse(numericUpDown1.Text);//ช่วยชาติ
            int study_sport = int.Parse(numericUpDown2.Text);//ซื้อสินค้าการศึกษาและกีฬา
            int book = int.Parse(numericUpDown3.Text);
            int otop = int.Parse(numericUpDown4.Text);
            int Town1 = int.Parse(numericUpDown5.Text);
            int Town2 = int.Parse(numericUpDown6.Text);
            int home = int.Parse(numericUpDown7.Text);
            int car = int.Parse(numericUpDown8.Text);
            int rd_pungpamern = int.Parse(textBox5.Text);
            int oc_final;
            int ooc;
            int i = 0;
            int o = 0;

            if ((Town1 + Town2) < 20000)
            {
                i = (Town1 + Town2);
            }
            else if ((Town1 + Town2) > 20001)
            {
                i = 20000;
            }
            if ((home + car) < 100000)
            {
                o = (home + car);
            }
            else if ((home + car) > 100001)
            {
                o = 100000;
            }

            ooc = (shop + study_sport + book + otop + i) + o;//รวมการล้อปทั้งหมด
            textBox6.Text = ooc.ToString();

            oc_final = rd_pungpamern - ooc;
            textBox7.Text = oc_final.ToString();
            //ลดหย่อนภาษี

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            m.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Group4 tax = new Group4();
            tax.textBox20.Text = textBox5.Text;
            tax.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group6 tax = new Group6();
            tax.textBox1.Text = textBox7.Text;
            tax.Show();
            this.Hide();
        }
    }
}
