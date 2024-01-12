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

namespace calculadoraWF
{
    public partial class btn_poten : Form
    {

        double primeiroValor = 0, segundoValor;
        string operacao = "";


        public btn_poten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btn_raiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt((double)primeiroValor));
                operacao = "raiz";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_apag_Click(object sender, EventArgs e)
        {
            string valorAtual = textBox1.Text;
            if (valorAtual.Length > 0)
            {
                valorAtual = valorAtual.Substring(0, valorAtual.Length - 1);
                textBox1.Text = valorAtual;
            }
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }



        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                operacao = "divi";
            }
        }




        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                operacao = "mult";
            }

        }

        private void btn_subt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                operacao = "sub";
            }
        }
        private void btn_som_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                primeiroValor = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                operacao = "soma";
            }
        }


        private void btn_igual_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                segundoValor = Convert.ToDouble(textBox1.Text);

                if (operacao == "soma")
                {
                    textBox1.Text = Convert.ToString(Calculos.soma(primeiroValor, segundoValor));
                }

                else if (operacao == "sub")//se não for soma, se for sutração: faça isso
                {
                    textBox1.Text = Convert.ToString(Calculos.subtracao ( primeiroValor, segundoValor));
                }

                else if (operacao == "mult")
                {
                    textBox1.Text = Convert.ToString(Calculos.multiplicacao(primeiroValor, segundoValor));
                }

                else if (operacao == "divi")
                {
                    textBox1.Text = Convert.ToString(Calculos.divisao (primeiroValor, segundoValor));   
                }

                else if (operacao == "raiz")
                {
                    textBox1.Text = Convert.ToString(Math.Sqrt((double)primeiroValor));
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            int primeiroValor = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(primeiroValor, 2));
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }




    }

}

