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
    public partial class UserControlGroup5 : UserControl
    {
        public UserControlGroup5()
        {
            InitializeComponent();

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
            foreach (Control n1 in groupBox2.Controls)
                if (n1 is NumericUpDown)
                {
                    n1.Text = "";
                }

            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //รายได้พึ่งประเมิน
            int sly = int.Parse(textBox4.Text);
            int bn = int.Parse(textBox2.Text);
            int rd_etc = int.Parse(textBox3.Text);
            int oc;

            oc = (sly * 12) + bn + rd_etc;
            textBox5.Text = oc.ToString();
            //รายได้พึ่งประเมิน
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

            //ภาษีที่ต้องจ่าย
            int ooc_final = int.Parse(textBox7.Text);
            int sf;
            
            if (oc_final > 5000000)
            {
                sf = (ooc_final * 35 / 100);
            }
            else if (ooc_final > 2000000)
            {
                sf = (ooc_final * 30 / 100);
            }
            else if (ooc_final > 1000000)
            {
                sf = (ooc_final * 25 / 100);
            }
            else if (ooc_final > 750000)
            {
                sf = (ooc_final * 20 / 100);
            }
            else if (ooc_final > 500000)
            {
                sf = (ooc_final * 15 / 100);
            }
            else if (ooc_final > 300000)
            {
                sf = (ooc_final * 10 / 100);
            }
            else if (ooc_final > 150000)
            {
                sf = (ooc_final * 5 / 100);
            }
            else
            {
                sf = (0);
            }

            textBox8.Text = sf.ToString();
        }
    }
}
