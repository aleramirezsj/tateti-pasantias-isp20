using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraVisual
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora micalcu;

        public FrmCalculadora()
        {
            InitializeComponent();
            micalcu = new Calculadora();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtresultado.Text= Convert.ToString(micalcu.MostrarResultado("+"));
        }

        private void txtnumero1_Leave(object sender, EventArgs e)
        {
            micalcu.IngresarValor(Convert.ToSingle(txtnumero1.Text), Convert.ToSingle(txtnumero2.Text));
        }

        private void txtnumero2_Leave(object sender, EventArgs e)
        {
            micalcu.IngresarValor(Convert.ToSingle(txtnumero1.Text), Convert.ToSingle(txtnumero2.Text));
        }
    }
}
