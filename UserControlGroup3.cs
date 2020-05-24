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
    public partial class UserControlGroup3 : UserControl
    {
        public UserControlGroup3()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNew.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (radioButtonSingle.Checked)
            {
                //2558
                int house2558 = int.Parse(numericUpDown3Run.Text);
                int taxhouse = int.Parse(numericUpDownHouse.Text);
                int Pungpamern = int.Parse(textBoxPungpamern.Text);
                int final;
                int outcome2558;
                int outcome5;
                int outcomefinal2558;

                outcome2558 = (house2558 * 20) / 100;
                textBox20Per.Text = outcome2558.ToString();
                outcome5 = (outcome2558 / 5);
                textBox5Years.Text = outcome5.ToString();
                outcomefinal2558 = (taxhouse + outcome5);
                textBoxPasi2558.Text = outcomefinal2558.ToString();

                final = Pungpamern - outcomefinal2558;
                textBoxSuti2558.Text = final.ToString();
                //2558
            }
            if (radioButtonNew.Checked)
            {
                //2562
                int valuehouse2562 = int.Parse(numericUpDown5Run.Text);
                int taxhouse2562 = int.Parse(numericUpDownHouse.Text);
                int Pungpamern2562 = int.Parse(textBoxPungpamern.Text);
                int final2562;
                int outcome2562;
                int outcomefinal2562;
                int i = 0;

                if (valuehouse2562 < 200000)
                {
                    i = valuehouse2562;
                }
                else if (valuehouse2562 < 5000001)
                {
                    i = 200000;
                }

                outcome2562 = i;
                textBoxPasi2Seen.Text = outcome2562.ToString();
                outcomefinal2562 = (taxhouse2562 + i);
                textBoxPasi2562.Text = outcomefinal2562.ToString();

                final2562 = Pungpamern2562 - outcomefinal2562;
                textBoxSuti2562.Text = final2562.ToString();
                //2562
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
                if (item.GetType().Equals(typeof(NumericUpDown)))
                {
                    NumericUpDown t1 = item as NumericUpDown;
                    t1.Text = string.Empty;
                }
                foreach (Control g1 in groupBox1.Controls)
                    if (g1 is NumericUpDown)
                    {
                        g1.Text = "";
                    }
                foreach (Control g11 in groupBox1.Controls)
                    if (g11 is TextBox)
                    {
                        g11.Text = "";
                    }
                foreach (Control g2 in groupBox2.Controls)
                    if (g2 is NumericUpDown)
                    {
                        g2.Text = "";
                    }
                foreach (Control g21 in groupBox2.Controls)
                    if (g21 is TextBox)
                    {
                        g21.Text = "";
                    }
                foreach (Control g3 in groupBox3.Controls)
                    if (g3 is TextBox)
                    {
                        g3.Text = "";
                    }
            }
        }
    }
}
