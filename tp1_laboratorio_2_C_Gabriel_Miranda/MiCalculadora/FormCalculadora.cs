using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        #region Metodos publicos
        
        public LaCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled=false;
        }
        #endregion
        #region Metodos Privados
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero toBinario = new Numero();
            lblResultado.Text = toBinario.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero toDecimal = new Numero();
            lblResultado.Text = toDecimal.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;

        }

        /// <summary>
        /// Metodo para limpiar TextBox, ComboBox y Label de la pantalla. Tambien ddesactiva conv a dec/bin
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedIndex = -1;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

           return Calculadora.Operar(num1, num2, operador);

        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNumero2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        


    }
}
