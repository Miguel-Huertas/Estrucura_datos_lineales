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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            
            if (txt_clave.Text != "")
            {
                if (txt_clave.Text == "123")
                {
                    principal p = new principal();
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ERROR \n Digite clave correcta");
                    txt_clave.Focus();
                    txt_clave.Clear();
                }
            }
            else
            {
                MessageBox.Show("Digite clave");
                txt_clave.Focus();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación ?", "Confirar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
