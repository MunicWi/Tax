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
    public partial class Group3 : Form
    {
        public Group3()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void radioButtonOld_CheckedChanged(object sender, EventArgs e)
        {
            //2558
            if (radioButtonOld.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
            //2558
        }


        //2562
        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonNew.Checked)
            {
                groupBox1.Enabled = true;
            }
            else 
            {
                groupBox1.Enabled = true;
            }
        }
        //2562
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonOld.Checked)
            {
                //2558
                int house2558 = int.Parse(numericUpDown3Run.Text); // มูลค่าอสังหา
                int taxhouse = int.Parse(numericUpDownHouse.Text); // ดอกเบี้ยบ้าน
                int Pungpamern = int.Parse(textBoxPungpamern.Text);
                int final; // สุทธิ
                int outcome2558;
                int outcome;
                int outcomefinal2558;

                outcome2558 = (house2558 * 20) / 100; // มูลค่าอสังหา
                textBox20Per.Text = outcome2558.ToString(); // สามารถลดหย่อนได้ 20 % ของมูลค่าอสังหาริมทรัพย์*
                outcome = ((outcome2558 *4 )/ 100);
                textBox5Years.Text = outcome.ToString(); // ฌฉลี่ยหย่อน 5 ปี
                outcomefinal2558 = (taxhouse + outcome);
                textBoxPasi.Text = outcomefinal2558.ToString(); // รวมลดหย่อนภาษี

                final = Pungpamern - outcomefinal2558;
                textBoxSuti.Text = final.ToString();
                //2558
            }

            if (radioButtonNew.Checked)
            {
                //2562
                int valuehouse2562 = int.Parse(numericUpDown5Run.Text);  // มูลค่าอสังหา
                int taxhouse2562 = int.Parse(numericUpDownHouse.Text); // ดอกเบี้ยบ้าน
                int Pungpamern2562 = int.Parse(textBoxPungpamern.Text); 
                int final2562; 
                int outcome2562;
                int outcomefinal2562;
                int i = 0;

                if (valuehouse2562 <= 200000)
                {
                    i = valuehouse2562;
                }
                else if (valuehouse2562 <= 5000000)
                {
                    i = 200000;
                }

                outcome2562 = i; //สามารถลดหย่อนภาษีได้
                textBoxPasi2Seen.Text = outcome2562.ToString();
                outcomefinal2562 = (taxhouse2562 + i); //รวมลดหย่อนภาษี
                textBoxPasi.Text = outcomefinal2562.ToString();

                final2562 = Pungpamern2562 - outcomefinal2562;
                textBoxSuti.Text = final2562.ToString();//รายได้สุทธิ
                //2562
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group4 tax = new Group4();
            tax.textBox20.Text = textBoxSuti.Text;
            tax.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Group4 tax = new Group4();
            tax.textBox20.Text = textBoxPungpamern.Text;
            tax.Show();
            this.Hide();
        }
    }
}
