using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioGraus
{
    public partial class graus : Form
    {
        public graus()
        {
            InitializeComponent();
        }
        int operacao = 1;
        int operacao2 = 1;
        private void Rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            operacao2 = 2;
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            double v1;          
            double res;

            if(operacao == 1 && operacao2 == 1)
            {
                txt_res.Text = txt_res.Text + txt_Valor1.Text;
            }
            if (operacao == 2 && operacao2 == 2)
            {
                txt_res.Text = txt_res.Text + txt_Valor1.Text;
            }
            if (operacao == 3 && operacao2 == 3)
            {
                txt_res.Text = txt_res.Text + txt_Valor1.Text;
            }
            if (operacao == 1 && operacao2 == 2)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = (v1 * 1.8) + 32;
                txt_res.Text = Convert.ToString(res);
            }
            if (operacao == 1 && operacao2 == 3)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 + 273.15;
                txt_res.Text = Convert.ToString(res);
            }
            if (operacao == 2 && operacao2 == 1)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = (v1 - 32) * 5 / 9;
                txt_res.Text = Convert.ToString(res);
            }
            if (operacao == 2 && operacao2 == 3)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = (v1 - 32) * 5 / 9 + 273.15;
                txt_res.Text = Convert.ToString(res);
            }
            if (operacao == 3 && operacao2 == 1)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 - 273.15;
                txt_res.Text = Convert.ToString(res);
            }
            if (operacao == 3 && operacao2 == 2)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = (v1 - 273.15) * 9 / 5 + 32;
                txt_res.Text = Convert.ToString(res);
            }
        }

        private void Rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void Rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void Rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void Rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            operacao2 = 1;
        }

        private void Rbtn6_CheckedChanged(object sender, EventArgs e)
        {
            operacao2 = 3;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Valor1.Text = "";
            txt_res.Text = "";

        }

        private void graus_Load(object sender, EventArgs e)
        {

        }
    }
}
