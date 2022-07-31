using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = "";
            double F01, F02, F03, F04, F05, F06, F07, F08, F09, F10, SUM;
            if (F1.Checked == true)
            {
                str += "\r\n\nຜັດກະເພົາໝູກອບ ລາຄາ 30.000 ກີບ";
                F01 = 30000;
            }
            else
            {
                F01 = 0;
            }
            if (F2.Checked == true)
            {
                str += "\r\n\nຜັດກະເພົາໝ້າປາເຄັມ  ລາຄາ 30.000 ກີບ";
                F02 = 30000;
            }
            else
            {
                F02 = 0;
            }
            if (F3.Checked == true)
            {
                str += "\r\n\nເຂົ້າຄູກກະປິ ລາຄາ 30.000 ກີບ";
                F03 = 30000;
            }
            else
            {
                F03 = 0;
            }
            if (F4.Checked == true)
            {
                str += "\r\n\nແກງປາ ລາຄາ 30.000 ກີບ";
                F04 = 30000;
            }
            else
            {
                F04 = 0;
            }
            if (F5.Checked == true)
            {
                str += "\r\n\nຫອຍລອດຜັດ ລາຄາ 30.000 ກີບ";
                F05 = 30000;
            }
            else
            {
                F05 = 0;
            }
            if (F6.Checked == true)
            {
                str += "\r\n\nເຂົ້າຂາໄກ່  ລາຄາ 30.000 ກີບ";
                F06 = 30000;
            }
            else
            {
                F06 = 0;
            }
            if (F7.Checked == true)
            {
                str += "\r\n\nເຂົ້່າຜັດທະເລ ລາຄາ 30.000 ກີບ";
                F07 = 30000;
            }
            else
            {
                F07 = 0;
            }
            if (F8.Checked == true)
            {
                str += "\r\n\nເຂົ້າຂາໝູ ລາຄາ 30.000 ກີບ";
                F08 = 30000;
            }
            else
            {
                F08 = 0;
            }
            if (F9.Checked == true)
            {
                str += "\r\n\nຕໍາມີ່  ລາຄາ 30.000 ກີບ";
                F09 = 30000;
            }
            else
            {
                F09 = 0;
            }
            if (F010.Checked == true)
            {
                str += "\r\n\nປີ້ງໄກ່  ລາຄາ 30.000 ກີບ";
                F10 = 30000;
            }
            else
            {
                F10 = 0;
            }
            SUM = F01 + F02 + F03 + F04 + F05 + F06 + F07 + F08 + F09 + F10;
            txtSum.Text = (SUM + " ກີບ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
