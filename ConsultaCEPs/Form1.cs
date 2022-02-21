using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEPs
{
    public partial class consultaInitial : Form
    {
        public consultaInitial()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           
                maskedCep.Text = string.Empty;
                textEstado.Text = string.Empty;
                textCidade.Text = string.Empty;
                textBairro.Text = string.Empty;
                textRua.Text = string.Empty;
            
            
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(maskedCep.Text.Trim());

                        textEstado.Text = endereco.uf;
                        textCidade.Text = endereco.cidade;
                        textBairro.Text = endereco.bairro;
                        textRua.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.horas.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
