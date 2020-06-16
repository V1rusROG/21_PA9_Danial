using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Danial_PA9
{
    public partial class Form1 : Form
    {
        private double ExchangeRate;
        public Form1()
        {
            InitializeComponent();
            ExchangeRate = 0;
        }

        private void Txt_Amount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Rb_USDollars_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeRate = 0.74;
        }

        private void Rb_JapaneseYen_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeRate = 81.97;
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(Txt_Amount.Text, out result))
            {
                Txt_Converted.Text = (result * ExchangeRate).ToString();
            }
            if (String.IsNullOrEmpty(Txt_Converted.Text))
            {
                MessageBox.Show("Please enter a valid amount!");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Amount.Text, "[-,+,/,=]"))
            {
                MessageBox.Show("Please enter a valid amount!");
                return;
            }
        }

        private void Txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Amount.Text = string.Empty;
            Txt_Converted.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
