using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        colas x = new colas();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtmaximo.Text);
            x = new colas(n);
            MessageBox.Show("Cola creada");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtnumero.Text);
            x.agregar_cola(n);
            MessageBox.Show("Valor agregado");
            txtnumero.Clear();
            txtnumero.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int n;
            n = x.del_cola();
            if (n == -666)
            {
                MessageBox.Show("Cola sin valores");
            }
            else
            {
                MessageBox.Show("salio" + n);
            }
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
