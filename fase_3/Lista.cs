using System;
using System.Collections;
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
    public partial class Lista : Form
    {
        private string tipo_id;
        private string num_id;
        private string nombre;
        private string edad;
        private string estrato;
        private string fecha;
        private string voto;
        private List<ListaEstudiantes> listaEstudiantes = new List<ListaEstudiantes>();

        public Lista()
        {
            InitializeComponent();
            this.menu_consultar.Enabled = false;
            this.menu_eliminar.Enabled = false;
            cargar_elementos_iniciales();
        }

        private void cargar_elementos_iniciales()
        {
            //limpiarmos campos
            this.com_tipo_id.Text = "";
            this.txt_num_id.Text = "";
            this.txt_nombre.Text = "";
            this.txt_edad.Text = "";
            this.gr_voto.Text = "";
            this.rd_no.Checked = false;
            this.rd_si.Checked = false;
            this.com_estrato.Text = "";
            this.dt_fecha.Value = DateTime.Now;

            // cargar valores

            this.com_tipo_id.Items.Clear();
            this.com_estrato.Items.Clear();

            this.com_tipo_id.Items.Add("CC");
            this.com_tipo_id.Items.Add("TI");
            this.com_tipo_id.Items.Add("CE");
            this.com_tipo_id.Items.Add("NIP");
            this.com_tipo_id.Items.Add("NIT");

            this.com_estrato.Items.Add("1");
            this.com_estrato.Items.Add("2");
            this.com_estrato.Items.Add("3");
            this.com_estrato.Items.Add("4");
            this.com_estrato.Items.Add("5");
            this.com_estrato.Items.Add("6");

            this.ActiveControl = this.com_tipo_id;
        }

        private bool validar_formulario()
        {
            string str_mng = "";

            this.tipo_id = this.com_tipo_id.Text.Trim();

            if (this.tipo_id.Equals(""))
            {
                str_mng = str_mng + "- Tipo Idenntificacion \n";
                this.ActiveControl = com_tipo_id;
            }

            this.num_id = this.txt_num_id.Text.Trim();

            if (this.num_id.Equals(""))
            {
                str_mng = str_mng + "- Numero Idenntificacion \n";
                this.ActiveControl = txt_num_id;
            }
            else
            {
                int identificacio = 0;
                bool numero = int.TryParse(this.num_id, out identificacio);

                if (!numero)
                {
                    str_mng = str_mng + "-La identificacion debe ser numerica \n";
                }
            }

            this.nombre = this.txt_nombre.Text.Trim();

            if (this.nombre.Equals(""))
            {
                str_mng = str_mng + "- Nombre Estudiante \n";
                this.ActiveControl = txt_nombre;
            }

            this.edad = this.txt_edad.Text.Trim();

            if (this.edad.Equals(""))
            {
                str_mng = str_mng + "- Edad Estudiante \n";
                this.ActiveControl = txt_edad;
            }
            else
            {
                int identificacio = 0;
                bool numero = int.TryParse(this.edad, out identificacio);

                if (!numero)
                {
                    str_mng = str_mng + "-La edad debe ser numerica \n";
                }
            }

            this.estrato = this.com_estrato.Text.Trim();

            if (this.estrato.Equals(""))
            {
                str_mng = str_mng + "- Estrato \n";
                this.ActiveControl = com_estrato;
            }
            if(this.rd_si.Checked == false && this.rd_no.Checked == false)
            {
                str_mng = str_mng + "¿Voto en elecciones? \n";
                this.ActiveControl = this.gr_voto;
                this.error.SetError(this.gr_voto, "Debe seleccionar una opcion");
            }
            else
            {
                if (this.rd_si.Checked == true)
                {
                    this.voto = "Si";
                    error.Clear();
                }

                if (this.rd_no.Checked == true)
                {
                    this.voto = "No";
                    error.Clear();
                }
            }

            if (!str_mng.Equals(""))
            {
                str_mng = "DEBE DILIGENCIAR LOS SIGUIENTES CAMPOS: \n ********************************************\n\n" + str_mng;
                MessageBox.Show(str_mng, "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (MessageBox.Show("¿Desea salir del formulario lista?", "Confirar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                principal my_principal = new principal();
                my_principal.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private ListaEstudiantes obtenercliente(string num_id)
        {
            foreach (ListaEstudiantes mi_lista in this.listaEstudiantes)
            {
                if (mi_lista.num_id.Equals(num_id))
                {
                    return mi_lista;
                }
            }

            return null;
        }
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validar_formulario())
            {
                ListaEstudiantes lista = new ListaEstudiantes();
                lista.tipo_id = this.tipo_id;
                lista.num_id = this.num_id;
                lista.nombre = this.nombre;
                lista.edad = this.edad;
                lista.estrato = this.estrato;
                lista.fecha = this.fecha;
                lista.voto = this.voto;
                if (obtenercliente(lista.num_id)!= null)
                {
                    MessageBox.Show("El cliente con Identificacion: " + lista.num_id + " ya existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ActiveControl = this.txt_num_id;
                }
                else
                {
                    this.listaEstudiantes.Add(lista);
                    dt_lista.DataSource = null;
                    dt_lista.DataSource = this.listaEstudiantes.ToArray();

                    MessageBox.Show(" El registro fue exitoso", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargar_elementos_iniciales();

                    this.menu_eliminar.Enabled = true;
                    this.menu_consultar.Enabled = true;
                }
                



            }
        }

        private void menu_consultar_Click(object sender, EventArgs e)
        {
            if (this.listaEstudiantes.Count > 0)
            {
                string num_id = this.txt_num_id.Text.Trim();

                if (num_id.Equals(""))
                {
                    MessageBox.Show("No hay identificacion para consultar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActiveControl = this.txt_num_id;
                }
                else
                {
                    ListaEstudiantes mi_lista = obtenercliente(num_id);

                    if (mi_lista != null)
                    {
                        this.com_tipo_id.Text = mi_lista.tipo_id;
                        this.txt_num_id.Text = mi_lista.num_id;
                        this.txt_nombre.Text = mi_lista.nombre;
                        this.txt_edad.Text = mi_lista.edad;
                        this.com_estrato.Text = mi_lista.estrato;
                        this.dt_fecha.Value = Convert.ToDateTime(mi_lista.fecha);
                        this.gr_voto.Text = mi_lista.voto;
                    }
                    else
                    {
                        MessageBox.Show("El cliente con Identificacion: " + num_id + " No existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = this.txt_num_id;
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros aun en la lista", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.menu_eliminar.Enabled = false;
                this.menu_consultar.Enabled = false;
            }
        }

        private void menu_eliminar_Click(object sender, EventArgs e)
        {
            if (this.listaEstudiantes.Count > 0)
            {
                string num_id = this.txt_num_id.Text.Trim();

                if (num_id.Equals(""))
                {
                    MessageBox.Show("No hay identificacion para consultar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActiveControl = this.txt_num_id;
                }
                else
                {
                    ListaEstudiantes mi_lista = obtenercliente(num_id);

                    if (mi_lista != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registro del estudiante?", "Confirar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this.listaEstudiantes.Remove(mi_lista);
                            dt_lista.DataSource = this.listaEstudiantes.ToArray();
                            MessageBox.Show("El registro fue eliminado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar_elementos_iniciales();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente con Identificacion: " + num_id + " No existe", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = this.txt_num_id;

                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros aun en la lista", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.menu_eliminar.Enabled = false;
                this.menu_consultar.Enabled = false;
            }
        }
    }
}
