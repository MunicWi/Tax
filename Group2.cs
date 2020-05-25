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
    public partial class Group2 : Form
    {
        public Group2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Group1 tax = new Group1();
            tax.textBoxPungpamern01.Text = textBoxPungpamern02.Text;
            tax.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //รายได้สุทธิ
            int Sungkoom = int.Parse(numericUpDownSungkoom.Text);
            int Live = int.Parse(numericUpDownLive.Text);
            int Healty = int.Parse(numericUpDownHealty.Text);
            int Fa_Mo = int.Parse(numericUpDownFatherANDMother.Text);
            int Cheep = int.Parse(numericUpDownCheep.Text);
            int Marry = int.Parse(numericUpDownMarry.Text);
            int Pay;

            int all;
            int de = int.Parse(textBoxPungpamern02.Text);
            int y = 0;
            int x = 0;
            if ((Live + Fa_Mo) > 100000)
            {
                y = 100000;
            }
            else if ((Live + Fa_Mo) < 100000)
            {
                y = Live + Fa_Mo;
            }
            if (radioButtonSingle.Checked) //โสด
            {
                x = 0;
            }
            else if (radioButtonHaveWork.Checked) // มีรายได้
            {
                x = 0;
            }
            if (radioButtonNoWork.Checked)
            {
                x = 10000;
            }
            if (Marry <= 10000)
            {
                Marry = Marry;
            }
            {
                Pay = Sungkoom + Live + Healty + Fa_Mo + Cheep + Marry;
                textBoxPay.Text = Pay.ToString();
                all = de - (Sungkoom + y + Healty + Cheep + Marry) + x;
                textBoxSuti.Text = all.ToString();
            }
            //รายได้สุทธิ





            
             
            
        }
        


        //ส่งข้อมูลไปยัง Group3
        private void button2_Click(object sender, EventArgs e)
        {
            Group3 tax = new Group3();
            tax.textBoxPungpamern.Text = textBoxSuti.Text;
            tax.Show();
            this.Hide();
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMarry.Enabled = false;
            label20.Enabled = false;
            label27.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Group3 tax = new Group3();
            tax.textBoxPungpamern.Text = textBoxPungpamern02.Text;
            tax.Show();
            this.Hide();
        }
        //ส่งข้อมูลไปยัง Group3

    }
}

