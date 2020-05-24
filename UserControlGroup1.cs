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
    public partial class UserControlGroup1 : UserControl
    {
        public UserControlGroup1()
        {
            InitializeComponent();
            groupBox5.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox4.Enabled = false;
            }
            else
            {
                groupBox4.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //รายได้พึงประเมิน
            int sly = int.Parse(textBox1.Text);//เงินเดือน
            int bn = int.Parse(textBox2.Text);//โบนัส
            int rd_etc = int.Parse(textBox3.Text);//รายได้อื่นๆ
            int oc;//เงินเดือน+โบนัส+รายได้อื่นๆ-ค่าลดหย่อนอื่นๆ

            oc = (sly * 12) + bn + rd_etc;
            textBoxPungpamern.Text = oc.ToString();
            //รายได้พึงประเมิน
            //ค่าลดหย่อน
            int self = int.Parse(numericUpDown1.Text);//ค่าลดหย่อนส่วนตัว / ครอบครัว
            int son = int.Parse(numericUpDown2.Text);//จำนวนบุตร
            int childing = int.Parse(numericUpDown3.Text);//ค่าฝากครรภ์และคลอดบุตร
            int disabled = int.Parse(numericUpDown4.Text);//อุปการะคนพิการจำนวน
            int childing_final;
            int disabled_final;
            int father = 0;
            int mother = 0;
            int father_marry = 0;
            int mother_marry = 0;
            int status = 0;
            int have_Son = 0;
            int oc_rodyon;


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



            if (radioButton6.Checked)//จำนวนบุตร 1 คน
            {
                have_Son = 30000;
            }
            else if (radioButton7.Checked)//จำนวนบุตรมากกว่า 1 คน
            {
                have_Son = 30000;
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


            
            childing_final = childing * 60000; //ค่าฝากครรภ์
            disabled_final = disabled * 60000; //พิการ

            oc_rodyon = self + son + childing_final + disabled_final + have_Son + status + father + mother + father_marry + mother_marry;
            textBoxRodyon.Text = oc_rodyon.ToString();//รายได้ลดหย่อนทั้งหมด


            //suti
            int rd_pungpamern = int.Parse(textBoxPungpamern.Text);
            int rd_rodyon = int.Parse(textBoxRodyon.Text);
            int oc_final;

            oc_final = rd_pungpamern - rd_rodyon;
            textBoxSuti.Text = oc_final.ToString();
            //suti
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
                    NumericUpDown n2 = item as NumericUpDown;
                    n2.Text = string.Empty;
                }

            }
            foreach (Control t1 in groupBox1.Controls)
                if (t1 is TextBox)
                {
                    t1.Text = "";
                }
            foreach (Control n1 in groupBox5.Controls)
                if (n1 is NumericUpDown)
                {
                    n1.Text = "";
                }
        }
    }
}
