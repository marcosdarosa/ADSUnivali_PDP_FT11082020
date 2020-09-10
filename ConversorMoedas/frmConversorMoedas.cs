using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoedas
{
    public partial class frmConversorMoedas : Form
    {
        double resultado = 0;

        public frmConversorMoedas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMoedaOrigem.Items.Add("REAL");
            cmbMoedaOrigem.Items.Add("DOLAR");
            cmbMoedaOrigem.Items.Add("EURO");
            cmbMoedaOrigem.Items.Add("LIBRA");

            cmbMoedaDestino.Items.Add("REAL");
            cmbMoedaDestino.Items.Add("DOLAR");
            cmbMoedaDestino.Items.Add("EURO");
            cmbMoedaDestino.Items.Add("LIBRA");
            
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbMoedaOrigem.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento da Moeda Origem!"); // Valida o preenchimento da moeda origem
                cmbMoedaOrigem.Focus();

                return;
            }

            if (String.IsNullOrEmpty(cmbMoedaDestino.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento do Moeda Destino!"); // Valida o preenchimento da moeda destino
                cmbMoedaDestino.Focus();

                return;
            }

            if (String.IsNullOrEmpty(mtxtVlrOrigem.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento do Valor na Origem!"); // Valida o preenchimento do valor na origem
                mtxtVlrOrigem.Focus();

                return;
            }

            if (String.IsNullOrEmpty(mtxtFatorDestino.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento do Fator de Conversão!"); // Valida o preenchimento do fator de conversão
                mtxtFatorDestino.Focus();

                return;
            }

            resultado = double.Parse(mtxtVlrOrigem.Text) * double.Parse(mtxtFatorDestino.Text);

            lblResultado.Text = cmbMoedaDestino.Text + " " + resultado.ToString();
        }

         private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtxtVlrOrigem.Clear();
            mtxtFatorDestino.Clear();
            lblResultado.Text = "";

            cmbMoedaOrigem.Focus();
        }
    }
}
