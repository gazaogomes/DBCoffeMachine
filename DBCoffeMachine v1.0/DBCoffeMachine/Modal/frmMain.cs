using DBCoffeMachine.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCoffeMachine.Modal
{
    public partial class frmMain : Form
    {
        clsGeneral clsGeneral = new clsGeneral();
        double totalCoins = 0;
        double totalCommands = 0;
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnInsertCoins_Click(object sender, EventArgs e)
        {
            gbCoins.Visible = true;
        }

        private void btn1cent_Click(object sender, EventArgs e)
        {
            totalCoins += 0.01;
            txtValorTotal.Text = Convert.ToString(totalCoins);
            return;
        }

        private void btn5cent_Click(object sender, EventArgs e)
        {
            clsGeneral.ErrorInsertCoins();
            return;
        }

        private void btn10cent_Click(object sender, EventArgs e)
        {
            clsGeneral.ErrorInsertCoins();
            return;
        }

        private void btn25cent_Click(object sender, EventArgs e)
        {
            totalCoins += 0.25;
            txtValorTotal.Text = Convert.ToString(totalCoins);
            return;
        }

        private void btn50cent_Click(object sender, EventArgs e)
        {
            totalCoins += 0.50;
            txtValorTotal.Text = Convert.ToString(totalCoins);
            return;
        }

        private void btn1real_Click(object sender, EventArgs e)
        {
            totalCoins += 1.00;
            txtValorTotal.Text = Convert.ToString(totalCoins);
            return;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tratando os checkBoxs
            if (cbItem1.Checked)
            {
                if (txtQtdItem1.Text != String.Empty)
                    totalCommands += 3.50 * Convert.ToInt32(txtQtdItem1.Text);
                else
                {
                    MessageBox.Show("Insira a quantidade do Capuccino.");
                    return;
                }
            }
            if (cbItem2.Checked)
            {
                if (txtQtdItem2.Text != String.Empty)
                    totalCommands += 4.00 * Convert.ToInt32(txtQtdItem2.Text);
                else
                {
                    MessageBox.Show("Insira a quantidade do Mocha.");
                    return;
                }
            }
            if (cbItem3.Checked)
            {
                if (txtQtdItem3.Text != String.Empty)
                    totalCommands += 3.00 * Convert.ToInt32(txtQtdItem3.Text);
                else
                {
                    MessageBox.Show("Insira a quantidade do Café com Leite.");
                    return;
                }
            }
            //if (cbItem1.Checked && cbItem2.Checked && cbItem3.Checked)
            //{
            //    if (txtQtdItem1.Text != String.Empty && txtQtdItem2.Text != String.Empty && txtQtdItem3.Text != String.Empty)
            //        totalCommands += (3.50 + 4.00 + 3.00) * (Convert.ToInt32(txtQtdItem1.Text) + Convert.ToInt32(txtQtdItem2.Text) + Convert.ToInt32(txtQtdItem3.Text));
            //    else
            //        MessageBox.Show("Insira a quantidade dos itens.");
            //}

            //Calculando
            if (totalCoins < totalCommands)
            {
                MessageBox.Show("O valor inserido é menor que o valor total do pedido.");
            }
            else if (totalCoins == totalCommands)
            {
                MessageBox.Show("Obrigado!  \n") ;
            }
            else
            {
                gbFinish.Visible = true;
                totalCoins = totalCoins - totalCommands;
                txtTroco.Text = Convert.ToString(totalCoins);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Close();

        }

        private void AtivaQtd()
        {
            if (cbItem1.Checked == true)
            {
                txtQtdItem1.Visible = true;
            }
            else
            {
                txtQtdItem1.Visible = false;
                txtQtdItem1.Text = "";
            }
            if (cbItem2.Checked == true)
            {
                txtQtdItem2.Visible = true;
            }
            else
            {
                txtQtdItem2.Visible = false;
                txtQtdItem2.Text = "";
            }
            if (cbItem3.Checked == true)
            {
                txtQtdItem3.Visible = true;
            }
            else
            {
                txtQtdItem3.Visible = false;
                txtQtdItem3.Text = "";
            }
        }

        private void cbItem1_CheckedChanged(object sender, EventArgs e)
        {
            AtivaQtd();
        }

        private void cbItem2_CheckedChanged(object sender, EventArgs e)
        {
            AtivaQtd();
        }

        private void cbItem3_CheckedChanged(object sender, EventArgs e)
        {
            AtivaQtd();
        }
    }
}
