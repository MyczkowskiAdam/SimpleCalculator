using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        static string sEquation;
        static char[] sEquationAr;
        static int tmp;
        static DataTable dtEquation = new DataTable();
        const string vars = "1234567890./*-+()";
        static bool valid;
        
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            sEquation = txtbOUT.Text;
            sEquationAr = sEquation.ToCharArray();
            validate();
            if (valid == true)
            {
                calc();
            }
            else
            {
                MessageBox.Show("Bad expression", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validate()
        {
            for (int i = 0; i < sEquation.Length; i++)
            {
                tmp = vars.IndexOf(sEquationAr[i]);
                if (tmp != -1)
                {
                    valid = true;
                }
            }
        }

        private void calc()
        {

            var product = dtEquation.Compute(sEquation, "");
            sEquation += "=" + product;
            txtbOUT.Clear();
            txtbOUT.Text = sEquation;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("0");
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText(".");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("/");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbOUT.Clear();
        }

        private void btnLbr_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("(");
        }

        private void btnRbr_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText(")");
        }
    }
}
