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
    public partial class UserControlGroup4 : UserControl
    {
        public UserControlGroup4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //รายได้พึงประเมิน
            int sly = int.Parse(textBox1.Text);//เงินเดือน
            int bn = int.Parse(textBox2.Text);//โบนัส
            int rd_etc = int.Parse(textBox3.Text);//รายได้อื่นๆ
            int ry_etc = int.Parse(textBox4.Text);//ค่าลดหย่อนอื่นๆ
            int oc;//เงินเดือน+โบนัส+รายได้อื่นๆ-ค่าลดหย่อนอื่นๆ

            oc = (sly * 12) + bn + rd_etc - ry_etc;
            textBox20.Text = oc.ToString();
            //รายได้พึงประเมิน
            //การบริจาก
            int hp_study = int.Parse(textBox6.Text);//เรียน
            int hp_rattaban = int.Parse(textBox7.Text);//รัฐบาล
            int hp_sport = int.Parse(textBox8.Text);//กีฬา
            int hp_public = int.Parse(textBox9.Text);//สาธารณะ
            int hp_storm = int.Parse(textBox10.Text);//พายุ
            int hp_etc = int.Parse(textBox11.Text);//ต่างๆ
            int hp_political = int.Parse(numericUpDown1.Text);//การเมือง
            int rd_final = oc;//รายได้จากพึงประเมิน
            int calraidaifinal;//คำนวณรายได้พึงประเมิน * 10/100
            int oo_final;
            int i = 0;
            int a1;//เรียน
            int a2;//รัฐบาล
            int a3;//กีฬา
            int a4;//สาธารณะ
            int a5;//พายุ
            int a6;//ต่างๆ
            int a7;//การเมือง
            int oo_fianl2;//รายได้จากการบริจากที่ผ่านการคำนวน + กันทั้งหมด


            a1 = (hp_study * 2);
            textBox5.Text = a1.ToString();
            a2 = (hp_rattaban * 2);
            textBox12.Text = a2.ToString();
            a3 = (hp_sport * 2);
            textBox13.Text = a3.ToString();
            a4 = (hp_public * 2);
            textBox14.Text = a4.ToString();
            a5 = hp_storm;
            textBox15.Text = a5.ToString();
            a6 = hp_etc;
            textBox16.Text = a6.ToString();
            a7 = hp_political;
            textBox17.Text = a7.ToString();

            calraidaifinal = (rd_final * 10) / 100; //คำนวณรายได้พึงประเมิน * 10/100

            oo_final = (a1 + a2 + a3 + a4 + a5 + a6 + a7); //รายได้จากการบริจากที่ผ่านการคำนวน + กันทั้งหมด
            if (oo_final > calraidaifinal)
            {
                i = calraidaifinal;
            }
            else if (oo_final < calraidaifinal)
            {
                i = oo_final;
            }
            textBox18.Text = i.ToString();

            oo_fianl2 = rd_final - i;
            textBox19.Text = oo_fianl2.ToString();
            //การบริจาก
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

            }
                foreach (Control t1 in groupBox1.Controls)
                if (t1 is TextBox)
                {
                    t1.Text = "";
                }
            foreach (Control t2 in groupBox2.Controls)
                if (t2 is TextBox)
                {
                    t2.Text = "";
                }
            foreach (Control n1 in groupBox2.Controls)
                if (n1 is NumericUpDown)
                {
                    n1.Text = "";
                }
          

        }
    }
}
