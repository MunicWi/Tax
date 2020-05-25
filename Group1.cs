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
    public partial class Group1 : Form
    {
        public Group1()
        {
            InitializeComponent();
            groupBox5.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void Group1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //กลับ
        }

        private void button1_Click(object sender, EventArgs e) //คำนวน
        {
            //ค่าลดหย่อน
            int self = int.Parse(numericUpDown1.Text);//ค่าลดหย่อนส่วนตัว / ครอบครัว
            int son1 = int.Parse(numericUpDown2.Text);//บุตรเกิดก่ิน 2561
            int son2 = int.Parse(numericUpDown5.Text);//บุตรเกิดก่ิน 2561
            int childing = int.Parse(numericUpDown3.Text);//ค่าฝากครรภ์และคลอดบุตร
            int disabled = int.Parse(numericUpDown4.Text);//อุปการะคนพิการจำนวน
            int father = 0; 
            int mother = 0; 
            int father_marry = 0; 
            int mother_marry = 0;
            int status = 0; //สถานะ
            int oc_rodyon; // สามารถลดหย่อนทั้งหมด






            if (radioButton1.Checked) //โสด
            {
                status = 0;
            }
            else if (radioButton2.Checked) //สรมีรายได้
            {
                status = 0;
            }
            else if (radioButton3.Checked) // สมรสไม่มีรายได้
            {
                status = 60000;
            }








            if (radioButton15.Checked) //บิดา มีชีวิตและอายุมากกว่า 60 ปี
            {
                father = 30000;
            }
            else if (radioButton14.Checked) //เสียชีวิต หรือ อายุต่ำกว่า 60 ปี
            {
                father = 0;
            }
            if (radioButton13.Checked) //มารดา มีชีวิตและอายุมากกว่า 60 ปี
            {
                mother = 30000;
            }
            else if (radioButton12.Checked) //มารดา เสียชีวิต หรือ อายุต่ำกว่า 60 ปี
            {
                mother = 0;
            }







            if (radioButton9.Checked) //บิดา คู่สมรส มีชีวิตและอายุมากกว่า 60 ปี
            {
                father_marry = 30000;
            }
            else if (radioButton8.Checked)//บิดา คู่สมรส เสียชีวิต หรือ อายุต่ำกว่า 60 ปี
            {
                father_marry = 0;
            }
            if (radioButton11.Checked)//มารดา คู่สมรส มีชีวิตและอายุมากกว่า 60 ปี
            {
                mother_marry = 30000;
            }
            else if (radioButton10.Checked)//มารดา คู่สมรส มีชีวิตและอายุมากกว่า 60 ปี
            {
                mother_marry = 0;
            }


            oc_rodyon = self + (son1 * 30000) + (son2 * 60000) + childing + disabled + status + father + mother + father_marry + mother_marry;
            textBoxRodyon.Text = oc_rodyon.ToString();//รายได้ลดหย่อนทั้งหมด






            //suti
            int rd_pungpamern = int.Parse(textBoxPungpamern01.Text);
            int rd_rodyon = int.Parse(textBoxRodyon.Text);
            int oc_final;

            oc_final = rd_pungpamern - rd_rodyon;
            textBoxSuti.Text = oc_final.ToString();
            //suti
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox5.Enabled = true;
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
                groupBox1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group2 tax = new Group2();
            tax.textBoxPungpamern02.Text = textBoxSuti.Text;
            tax.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Group2 tax = new Group2();
            tax.textBoxPungpamern02.Text = textBoxSuti.Text;
            tax.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Enabled = false;
            groupBox9.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Enabled = true;
            groupBox9.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Enabled = true;
            groupBox9.Enabled = true;
        }
    }
}
