using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows10
{
    public partial class Form1 : Form
    {
        double n1, n2, res;
        String operacao;

        public Form1()
        {
            InitializeComponent();

            txtPainel.Text = "0";
            
        }
        

        private void txtPainel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsDigit(e.KeyChar)) && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != 08))
            {
                e.Handled = true;
            }
            else
            {
                if((e.KeyChar == ',' || e.KeyChar == '.') && (((TextBox)sender).Text.Contains('.') || ((TextBox)sender).Text.Contains(',')))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String operacao = ((Button)sender).Text;

            switch (operacao)
            {
                case "1":
                    if (txtPainel.Text != "0")
                    {
                        if(operacao == "")
                        {
                            txtPainel.Text += "1";
                        }
                        else
                        {
                            txtPainel.Text += "1";
                        }
                        
                    }
                    else
                    {
                        txtPainel.Text = "1";
                    }
                    break;

                case "2":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "2";
                        }
                        else
                        {
                            txtPainel.Text += "2";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "2";
                    }
                    break;

                case "3":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "3";
                        }
                        else
                        {
                            txtPainel.Text += "3";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "3";
                    }
                    break;

                case "4":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "4";
                        }
                        else
                        {
                            txtPainel.Text += "4";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "4";
                    }
                    break;

                case "5":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "5";
                        }
                        else
                        {
                            txtPainel.Text += "5";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "5";
                    }
                    break;

                case "6":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "6";
                        }
                        else
                        {
                            txtPainel.Text += "6";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "6";
                    }
                    break;

                case "7":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "7";
                        }
                        else
                        {
                            txtPainel.Text += "7";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "7";
                    }
                    break;

                case "8":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "8";
                        }
                        else
                        {
                            txtPainel.Text += "8";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "8";
                    }
                    break;

                case "9":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "9";
                        }
                        else
                        {
                            txtPainel.Text += "9";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "9";
                    }
                    break;

                case "0":
                    if (txtPainel.Text != "0")
                    {
                        if (operacao == "")
                        {
                            txtPainel.Text += "0";
                        }
                        else
                        {
                            txtPainel.Text += "0";
                        }
                    }
                    else
                    {
                        txtPainel.Text = "0";
                    }
                    break;
            }                    
        }
        
        private void btnC_Click(object sender, EventArgs e)
        {
            txtPainel.Text = "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPainel.Text = txtPainel.Text.Remove(txtPainel.Text.Length - 1);
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            double num = 0;

            num = Convert.ToDouble(txtPainel.Text);

            num *= num;

            txtPainel.Text = Convert.ToString(num);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double num = 0;

            num = Convert.ToDouble(txtPainel.Text);

            num = Math.Sqrt(num); ;

            txtPainel.Text = Convert.ToString(num);
        }

        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            double num = 0;

            num = Convert.ToDouble(txtPainel.Text);

            num *= -1;

            txtPainel.Text = Convert.ToString(num);
        }

        private void btnSobreX_Click(object sender, EventArgs e)
        {
            double num = 0;

            num = Convert.ToDouble(txtPainel.Text);

            if(num == 0)
            {
                 MessageBox.Show("Não é possível dividir por zero");
            }
            else
            {
                num = 1 / num;

                txtPainel.Text = Convert.ToString(num);
            }
                       
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
                        
            n1 = Convert.ToDouble(txtPainel.Text);

            txtPainel.Text = "0";

            Button botao = (Button)sender;
            operacao = botao.Text;

            switch (operacao)
            {
                case "+":
                    operacao = "+";
                    break;

                case "-":
                    operacao = "-";
                    break;

                case "*":
                    operacao = "*";
                    break;

                case "/":
                    operacao = "/";
                    break;
            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtPainel.Text);

            switch(operacao){
                case "+":
                    res = n1 + n2;
                    txtPainel.Text = Convert.ToString(res);
                    break;

                case "-":
                    res = n1 - n2;
                    txtPainel.Text = Convert.ToString(res);
                    break;

                case "*":
                    res = n1 * n2;
                    txtPainel.Text = Convert.ToString(res);
                    break;

                case "/":
                    res = n1 / n2;
                    txtPainel.Text = Convert.ToString(res);
                    break;

                case "1/x":
                    int i = 0;
                    res = n1;

                    while(i < n2-1)
                    {
                        res *= n1;
                        i++;
                    }
                    txtPainel.Text = Convert.ToString(res);
                    break;
            }
        }
    }
}
