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
    public partial class Cola : Form
    {

        private string identificacion;
        private string nombre;
        private string direccion;
        private string comuna;
        private string genero;
        private string fecha;
        private string auxilio;
        private int total_reistros;
        private Queue<colajuventud> colajuventud = new Queue<colajuventud>();


        public Cola()
        {
            InitializeComponent();
            this.menu_eliminar.Enabled = false;
            this.menu_reporte.Enabled = false;
            cargar_elementos_iniciales();
        }

        private void cargar_elementos_iniciales()
        {
            //limpiar campos
            this.txt_id.Text = "";
            this.txt_nombre.Text = "";
            this.txt_direccion.Text = "";
            this.com_comuna.Text = "";
            this.com_genero.Text = "";
            this.dt_fecha.Value = DateTime.Now;

            //cargar valores

            this.com_comuna.Items.Clear();
            this.com_genero.Items.Clear();

            this.com_comuna.Items.Add("1");
            this.com_comuna.Items.Add("2");
            this.com_comuna.Items.Add("3");
            this.com_comuna.Items.Add("4");
            this.com_comuna.Items.Add("5");
            this.com_comuna.Items.Add("6");
            this.com_comuna.Items.Add("7");
            this.com_comuna.Items.Add("8");
            this.com_comuna.Items.Add("9");
            this.com_comuna.Items.Add("10");

            this.com_genero.Items.Add("Mascuino");
            this.com_genero.Items.Add("Femenino");
            this.com_genero.Items.Add("No Binario");

            this.ActiveControl = this.txt_id;

        }

        private bool validar_formulario()
        {
            string str_msg = "";

            this.identificacion = this.txt_id.Text.Trim();
            if (this.identificacion.Equals(""))
            {
                str_msg = str_msg + "-Número Identificacion \n";
                this.ActiveControl = this.txt_id;
            }
            else
            {
                int identificacio = 0;
                bool numero = int.TryParse(this.identificacion, out identificacio);

                if (!numero)
                {
                    str_msg = str_msg + "-La identificacion debe ser numerica \n";
                }
            }

            this.nombre = this.txt_nombre.Text.Trim();
            if (this.nombre.Equals(""))
            {
                str_msg = str_msg + "-Nombre completo \n";
                this.ActiveControl = this.txt_nombre;
            }

            this.direccion = this.txt_direccion.Text.Trim();
            if (this.direccion.Equals(""))
            {
                str_msg = str_msg + "-Direccion \n";
                this.ActiveControl = this.txt_direccion;
            }

            this.comuna = this.com_comuna.Text.Trim();
            if (this.comuna.Equals(""))
            {
                str_msg = str_msg + "-Comuna \n";
                this.ActiveControl = this.com_comuna;
            }
            else
            {

                if (comuna == "1" || comuna == "8" || comuna == "10")
                {
                    this.auxilio = "$ 100.000";
                }
                else
                {
                    this.auxilio = "$ 50.000";
                }
            }

            this.genero = this.com_genero.Text.Trim();
            if (this.genero.Equals(""))
            {
                str_msg = str_msg + "-Genero \n";
                this.ActiveControl = this.com_genero;
            }

            if (!str_msg.Equals(""))
            {
                str_msg = "DEBE DILIGENCIAR LOS SIGUIENTES CAMPOS: \n ********************************************\n\n" + str_msg;
                MessageBox.Show(str_msg, "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.fecha = this.dt_fecha.Value.ToString();
                return true;
            }
        }
        
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del formulario pila?", "Confirar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                principal my_principal = new principal();
                my_principal.Show();
                this.Hide();
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validar_formulario())
            {
                colajuventud mi_cola = new colajuventud();
                mi_cola.identificacion = this.identificacion;
                mi_cola.nombre = this.nombre;
                mi_cola.direccion = this.direccion;
                mi_cola.comuna = this.comuna;
                mi_cola.genero = this.genero;
                mi_cola.fecha = this.fecha;
                mi_cola.Auxilio_Economico = this.auxilio;
                colajuventud.Enqueue(mi_cola);
                this.total_reistros = this.total_reistros + 1;

                dg_cola.DataSource = null;
                dg_cola.DataSource = this.colajuventud.ToArray();

                MessageBox.Show(" El registro fue exitoso", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargar_elementos_iniciales();

                this.menu_eliminar.Enabled = true;
                this.menu_reporte.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menu_reporte_Click(object sender, EventArgs e)
        {
            this.txt_total_registros.Text = this.total_reistros.ToString();
        }

        private void menu_eliminar_Click(object sender, EventArgs e)
        {
            if (this.colajuventud.Count() > 0)
            {
                if (MessageBox.Show("¿desea eliminar el ultimo registro de la cola?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    colajuventud mi_cola = new colajuventud();
                    mi_cola = this.colajuventud.Dequeue();
                    this.total_reistros = this.total_reistros - 1;
                    this.txt_total_registros.Text = this.txt_total_registros.ToString();
                    dg_cola.DataSource = this.colajuventud.ToArray();
                    MessageBox.Show("El ultimo registro fue eliminado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No hay registros aun en la pila", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.menu_eliminar.Enabled = false;
                this.menu_reporte.Enabled = false;
            }
        }
    }
}
