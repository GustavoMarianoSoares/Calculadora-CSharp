using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text += ".";
            }
            else
            {
                MessageBox.Show("Informe um valor para por o ponto");
            }

        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao== "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else 
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
           
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SUB";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }
  
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a operação");
            }

        }
    }
}
