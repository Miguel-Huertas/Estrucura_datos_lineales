using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fase_3
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación ?", "Confirar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }

        private void btn_pila_Click(object sender, EventArgs e)
        {
            Pila p = new Pila();
            p.Show();
            this.Hide();
        }

        private void btn_cola_Click(object sender, EventArgs e)
        {
            Cola p = new Cola();
            p.Show();
            this.Hide();
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            Lista p = new Lista();
            p.Show();
            this.Hide();
        }
    }
}
