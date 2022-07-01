using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week6_1
{
    public partial class Form1 : Form
    {
        STU stu_1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            STU STU_1 = new STU();
            STU_1.ID = "B0226497_1";
            STU_1.NAME = "段昱如_1";
            STU_1.PHONE = "123456";
            STU_1.chi =-7;
            STU_1.math = 35;
            STU_1.eng = 65;
            string str = $"第1位學生:{STU_1.PRINTME()}";
            STU STU_2 = new STU();
            STU_2.ID = "B0226497_2";
            STU_2.NAME = "段昱如_2";
            STU_2.PHONE = "234567";
            STU_2.chi = 114;
            STU_2.math = 97;
            STU_2.eng = 78;
            str += $"\n第2位學生:{STU_2.PRINTME()}";
            STU STU_3 = new STU();
            STU_3.ID = "B0226497_3";
            STU_3.NAME = "段昱如_3";
            STU_3.PHONE = "345678";
            STU_3.chi = -9;
            STU_3.math = 64;
            STU_3.eng = 34;
            str += $"\n第3位學生:{STU_3.PRINTME()}";
            STU STU_4 = new STU();
            STU_4.ID = "B0226497_4";
            STU_4.NAME = "段昱如_4";
            STU_4.PHONE = "456789";
            STU_4.chi = 67;
            STU_4.math = 25;
            STU_4.eng = 49;
            str += $"\n第4位學生:{STU_4.PRINTME()}";
            STU STU_5 = new STU();
            STU_5.ID = "B0226497_5";
            STU_5.NAME = "段昱如_5";
            STU_5.PHONE = "567890";
            STU_5.chi = 100;
            STU_5.math = 97;
            STU_5.eng = 120;
            str += $"\n第5位學生:{STU_5.PRINTME()}";
            lblRESULT.Text = str;
            
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
