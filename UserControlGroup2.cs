using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_All
{
    public partial class UserControlGroup2 : UserControl
    {
        public UserControlGroup2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int raidai;
            //int moneymounth = int.Parse(numericUpDown1.Text);
            //int Bonus = int.Parse(numericUpDown2.Text);

            //raidai = moneymounth + Bonus;
            //textBox4.Text = raidai.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHaveWork_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHaveWork.Checked)
            {
                numericUpDownMarry.Enabled = false;
            }
            else 
            {
                numericUpDownMarry.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Text = string.Empty;                 
                }
            foreach (Control n in groupBox2.Controls)
                if (n is NumericUpDown)
                {
                    n.Text = "";
                }
            foreach (Control t2 in groupBox3.Controls)
                if (t2 is TextBox)
                {
                    t2.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //พึ่งประเมิน
            int tb1 = int.Parse(month.Text);
            int tb2 = int.Parse(bonus.Text);
            int tb3 = int.Parse(et.Text);
            int outcome;
            int income;


            income = (tb1 * 12);
            outcome = income + tb2 + tb3;
            textBoxPungpamern.Text = outcome.ToString();
            //พึ่งประเมิน
            //รายได้สุทธิ
            int db1 = int.Parse(numericUpDownSungkoom.Text);
            int db2 = int.Parse(numericUpDownLive.Text);
            int db3 = int.Parse(numericUpDownHealty.Text);
            int db4 = int.Parse(numericUpDownFatherANDMother.Text);
            int db5 = int.Parse(numericUpDownCheep.Text);
            int db6 = int.Parse(numericUpDownMarry.Text);

            int all;
            int de = int.Parse(textBoxPungpamern.Text);
            int y = 0;
            int x = 0;
            if ((db2 + db4) > 100000)
            {
                y = 100000;
            }
            else if ((db2 + db4) < 100000)
            {
                y = db2 + db4;
            }
            if (radioButtonSingle.Checked)
            {
                x = 0;
            }
            else if (radioButtonHaveWork.Checked)
            {
                x = 0;
            }
            if (db6 <= 10000)
            {
                db6 = db6;
            }
            {
                all = de - (db1 + y + db3 + db5 + db6) + x;
                textBoxSuti.Text = all.ToString();
            }
            //รายได้สุทธิ
            //
            int sec = int.Parse(textBoxSuti.Text);
            if (sec > 5000000)
            {
                sec = (sec * 35 / 100);
            }
            else if (sec > 2000000)
            {
                sec = (sec * 30 / 100);
            }
            else if (sec > 1000000)
            {
                sec = (sec * 25 / 100);
            }
            else if (sec > 750000)
            {
                sec = (sec * 20 / 100);
            }
            else if (sec > 500000)
            {
                sec = (sec * 15 / 100);
            }
            else if (sec > 300000)
            {
                sec = (sec * 10 / 100);
            }
            else if (sec > 150000)
            {
                sec = (sec * 5 / 100);
            }
            else
            {
                sec = (0);
            }
            textBoxPay.Text = sec.ToString();
        }
    }
}
