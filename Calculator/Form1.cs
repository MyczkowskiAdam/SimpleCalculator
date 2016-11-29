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
        static DataTable dtEquation = new DataTable();
        
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            sEquation = txtbOUT.Text;
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
            blockOperators();
        }

        private void btnLbr_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText("(");
        }

        private void btnRbr_Click(object sender, EventArgs e)
        {
            txtbOUT.AppendText(")");
        }

        private void txtbOUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            blockOperators();
        }

        private void blockOperators()
        {
            btnAdd.Enabled = false;
            btnDiv.Enabled = false;
            btnSub.Enabled = false;
            btnMulti.Enabled = false;
        }

        private void enableOperators()
        {
            btnAdd.Enabled = true;
            btnDiv.Enabled = true;
            btnSub.Enabled = true;
            btnMulti.Enabled = true;
        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }

        private void btn0_MouseClick(object sender, MouseEventArgs e)
        {
            enableOperators();
        }
    }
}
