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

namespace fase_3
{
    public partial class Pila : Form
    {
        private string str_valor_cdt;
        private string str_numero_cdt;
        private string str_id_cliente;
        private string str_nom_client;
        private string str_direccion_cliente;
        private string str_tiempo_cdt;
        private string str_categoria;
        private string str_estrato;
        private string str_mes_apertura;
        private string str_fecha_pago;
        private int int_valor_pagar;
        private int int_total_recaudo;
        Stack<pilaCdt> pilaCdt = new Stack<pilaCdt>();
        
        public Pila()
        {
            InitializeComponent();
            this.menu_eliminar.Enabled = false;
            this.menu_reporte.Enabled = false;
            Cargar_elementos_iniciales();
        }

        private void Cargar_elementos_iniciales()
        {
            //limiar campos 
            this.txt_valor_cdt.Text = "";
            this.txt_numero_cdt.Text = "";
            this.txt_id_cliente.Text = "";
            this.txt_nom_cliente.Text = "";
            this.txt_direccion_cliente.Text = "";
            this.txt_tiempo_cdt.Text = "";
            this.txt_valor_pagar.Text = "";
            this.txt_total_recaudo.Text = "";
            this.com_categoria.Text = "";
            this.com_estrto.Text = "";
            this.com_mes_apertura.Text = "";
            this.dt_fecha_pago.Value = DateTime.Now;
            this.ActiveControl = this.txt_numero_cdt;
        }

        private bool validar_formulario()
        {

            string str_Msg = "";

            this.str_valor_cdt = this.txt_valor_cdt.Text.Trim();
            if (this.str_valor_cdt.Equals(""))
            {
                str_Msg = str_Msg + "- Valor CDT \n";
                this.ActiveControl = this.txt_valor_cdt;
            }
            else
            {
                int int_valor_cdt = 0;
                bool valor_cdt = int.TryParse(this.str_valor_cdt, out int_valor_cdt);

                if (!valor_cdt)
                {
                    str_Msg = str_Msg + "- El valor de CDT es incorrecto \n";
                }
            }
           

            this.str_numero_cdt = this.txt_numero_cdt.Text.Trim();
            if (this.str_numero_cdt.Equals(""))
            {
                str_Msg = str_Msg + "- Numero del CDT \n";
                this.ActiveControl = this.txt_numero_cdt;
            }
            else
            {
                int int_numero_cdt = 0;
                bool numero_cdt = int.TryParse(this.str_numero_cdt, out int_numero_cdt);

                if (!numero_cdt)
                {
                    str_Msg = str_Msg + "- El numero CDT es incorrecto \n";
                }
            }


            this.str_id_cliente = this.txt_id_cliente.Text.Trim();
            if (this.str_id_cliente.Equals(""))
            {
                str_Msg = str_Msg + "- Nuemro Idenficicscion cliente \n";
                this.ActiveControl = this.txt_id_cliente;
            }
            else
            {
                int int_id_cliente = 0;
                bool id_cliente = int.TryParse(this.str_id_cliente, out int_id_cliente);

                if (!id_cliente)
                {
                    str_Msg = str_Msg + "- La identificacion es incorrecto \n";
                }
            }

            this.str_nom_client = this.txt_nom_cliente.Text.Trim();
            if (this.str_nom_client.Equals(""))
            {
                str_Msg = str_Msg + "- Nombre Cliente \n";
                this.ActiveControl = this.txt_nom_cliente;
            }

            this.str_direccion_cliente = this.txt_direccion_cliente.Text.Trim();
            if (this.str_direccion_cliente.Equals(""))
            {
                str_Msg = str_Msg + "- Direccion Cliente \n";
                this.ActiveControl = this.txt_direccion_cliente;
            }

            this.str_mes_apertura = this.com_mes_apertura.Text.Trim();
            if (this.str_mes_apertura.Equals(""))
            {
                str_Msg = str_Msg + "- Mes apertura \n";
                this.ActiveControl = this.com_mes_apertura;
            }

            this.str_estrato = this.com_estrto.Text.Trim();
            if (this.str_estrato.Equals(""))
            {
                str_Msg = str_Msg + "- Estrato \n";
                this.ActiveControl = this.com_estrto;
            }
            

            this.str_categoria = this.com_categoria.Text.Trim();
            if (this.str_categoria.Equals(""))
            {
                str_Msg = str_Msg + "- Categoria\n";
                this.ActiveControl = this.com_categoria;
            }

            this.str_tiempo_cdt = this.txt_tiempo_cdt.Text.Trim();
            if (this.str_tiempo_cdt.Equals(""))
            {
                str_Msg = str_Msg + "- Tiempo del CDT \n";
                this.ActiveControl = this.txt_tiempo_cdt;
            }
            else
            {
                int int_valor_cdt = 0;
                bool valor_cdt = int.TryParse(this.str_valor_cdt, out int_valor_cdt);

                int int_tiempo_cdt = 0;
                bool tiempo_cdt = int.TryParse(this.str_tiempo_cdt, out int_tiempo_cdt);

                if (!tiempo_cdt)
                {
                    str_Msg = str_Msg + "- El tiempo es incorrecto \n";
                }
                else
                {
                    if (int_tiempo_cdt >= 1 && int_tiempo_cdt <= 12)
                    {
                        this.int_valor_pagar = int_valor_cdt + ((int_valor_cdt*2) /1000)* int_tiempo_cdt;
                        this.txt_valor_pagar.Text = this.int_valor_pagar.ToString();
                    }
                    else if (int_tiempo_cdt >= 13 && int_tiempo_cdt <= 24)
                    {
                        this.int_valor_pagar = int_valor_cdt + ((int_valor_cdt *3) / 1000) * int_tiempo_cdt;
                        this.txt_valor_pagar.Text = this.int_valor_pagar.ToString();
                    }
                    else if (int_tiempo_cdt >= 25)
                    {
                        this.int_valor_pagar = int_valor_cdt + ((int_valor_cdt *5) /1000) * int_tiempo_cdt;
                        this.txt_valor_pagar.Text = this.int_valor_pagar.ToString();
                    }
                }

            }
            

            if (!str_Msg.Equals(""))
            {
                str_Msg = "DEBE DILIGENCIAR LOS SIGUIENTES CAMPOS: \n ********************************************\n\n" + str_Msg;
                MessageBox.Show(str_Msg, "Validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.str_fecha_pago = this.dt_fecha_pago.Value.ToString();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_eliminar_Click(object sender, EventArgs e)
        {
            if (this.pilaCdt.Count() > 0)
            {
                if (MessageBox.Show("¿desea eliminar el iltimo registro de la pila?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
                {

                }

                pilaCdt mi_pila = new pilaCdt();
                mi_pila = this.pilaCdt.Pop();
                this.int_total_recaudo = this.int_total_recaudo - mi_pila.int_valor_pagar;
                this.txt_total_recaudo.Text = this.int_total_recaudo.ToString();
                dg_pila.DataSource = this.pilaCdt.ToArray();
                MessageBox.Show("El ultimo registro fue eliminado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay registros aun en la pila", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.menu_eliminar.Enabled = false;
                this.menu_reporte.Enabled = false;

            }
        }

        private void com_mes_apertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_registrar_Click(object sender, EventArgs e)
        {

            if (validar_formulario())
            {

                
                pilaCdt mi_pila = new pilaCdt();
                mi_pila.str_valor_cdt = this.str_valor_cdt;
                mi_pila.str_numero_cdt = this.str_numero_cdt;
                mi_pila.str_id_cliente = this.str_id_cliente;
                mi_pila.str_nom_client = this.str_nom_client;
                mi_pila.str_direccion_cliente = this.str_direccion_cliente;
                mi_pila.str_tiempo_cdt = this.str_tiempo_cdt;
                mi_pila.int_valor_pagar = this.int_valor_pagar;
                mi_pila.str_categoria = this.str_categoria;
                mi_pila.str_estrato = this.str_estrato;
                mi_pila.str_mes_apertura = this.str_mes_apertura;
                mi_pila.str_fecha_pago = this.str_fecha_pago;
                this.int_total_recaudo = this.int_total_recaudo + this.int_valor_pagar;
                pilaCdt.Push(mi_pila);

                dg_pila.DataSource = null;
                dg_pila.DataSource = pilaCdt.ToArray();
                MessageBox.Show(" El registro fue exitoso", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cargar_elementos_iniciales();
                
                this.menu_eliminar.Enabled = true;
                this.menu_reporte.Enabled = true;

                
                
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_reporte_Click(object sender, EventArgs e)
        {
            this.txt_total_recaudo.Text = int_total_recaudo.ToString();
        }
    }
}
