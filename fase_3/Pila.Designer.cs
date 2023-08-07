namespace fase_3
{
    partial class Pila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numero_cdt = new System.Windows.Forms.TextBox();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.com_mes_apertura = new System.Windows.Forms.ComboBox();
            this.com_estrto = new System.Windows.Forms.ComboBox();
            this.txt_nom_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_direccion_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.com_categoria = new System.Windows.Forms.ComboBox();
            this.txt_tiempo_cdt = new System.Windows.Forms.TextBox();
            this.txt_valor_pagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_pila = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_fecha_pago = new System.Windows.Forms.DateTimePicker();
            this.txt_total_recaudo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_valor_cdt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pila)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(685, 415);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 0;
            this.btn_regresar.Text = "Regresar menu ";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de CDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero identificacion cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mes apertura CDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estrato";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tiempo del CDT (Meses)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categoria";
            // 
            // txt_numero_cdt
            // 
            this.txt_numero_cdt.Location = new System.Drawing.Point(224, 41);
            this.txt_numero_cdt.Name = "txt_numero_cdt";
            this.txt_numero_cdt.Size = new System.Drawing.Size(161, 20);
            this.txt_numero_cdt.TabIndex = 7;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(224, 99);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(161, 20);
            this.txt_id_cliente.TabIndex = 8;
            // 
            // com_mes_apertura
            // 
            this.com_mes_apertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_mes_apertura.FormattingEnabled = true;
            this.com_mes_apertura.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.com_mes_apertura.Location = new System.Drawing.Point(558, 73);
            this.com_mes_apertura.Name = "com_mes_apertura";
            this.com_mes_apertura.Size = new System.Drawing.Size(161, 21);
            this.com_mes_apertura.TabIndex = 9;
            this.com_mes_apertura.SelectedIndexChanged += new System.EventHandler(this.com_mes_apertura_SelectedIndexChanged);
            // 
            // com_estrto
            // 
            this.com_estrto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_estrto.FormattingEnabled = true;
            this.com_estrto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.com_estrto.Location = new System.Drawing.Point(558, 103);
            this.com_estrto.Name = "com_estrto";
            this.com_estrto.Size = new System.Drawing.Size(161, 21);
            this.com_estrto.Sorted = true;
            this.com_estrto.TabIndex = 10;
            // 
            // txt_nom_cliente
            // 
            this.txt_nom_cliente.Location = new System.Drawing.Point(224, 131);
            this.txt_nom_cliente.Name = "txt_nom_cliente";
            this.txt_nom_cliente.Size = new System.Drawing.Size(161, 20);
            this.txt_nom_cliente.TabIndex = 12;
            this.txt_nom_cliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre cliente";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente.Location = new System.Drawing.Point(224, 162);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(161, 20);
            this.txt_direccion_cliente.TabIndex = 16;
            this.txt_direccion_cliente.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Direccion cliente";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // com_categoria
            // 
            this.com_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_categoria.FormattingEnabled = true;
            this.com_categoria.Items.AddRange(new object[] {
            "Comercial",
            "Residencial",
            "Urbano"});
            this.com_categoria.Location = new System.Drawing.Point(558, 135);
            this.com_categoria.Name = "com_categoria";
            this.com_categoria.Size = new System.Drawing.Size(161, 21);
            this.com_categoria.Sorted = true;
            this.com_categoria.TabIndex = 17;
            // 
            // txt_tiempo_cdt
            // 
            this.txt_tiempo_cdt.Location = new System.Drawing.Point(558, 167);
            this.txt_tiempo_cdt.Name = "txt_tiempo_cdt";
            this.txt_tiempo_cdt.Size = new System.Drawing.Size(161, 20);
            this.txt_tiempo_cdt.TabIndex = 18;
            // 
            // txt_valor_pagar
            // 
            this.txt_valor_pagar.Enabled = false;
            this.txt_valor_pagar.Location = new System.Drawing.Point(401, 215);
            this.txt_valor_pagar.Name = "txt_valor_pagar";
            this.txt_valor_pagar.Size = new System.Drawing.Size(161, 20);
            this.txt_valor_pagar.TabIndex = 20;
            this.txt_valor_pagar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valor a pagar por el CDT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dg_pila
            // 
            this.dg_pila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pila.Location = new System.Drawing.Point(64, 256);
            this.dg_pila.Name = "dg_pila";
            this.dg_pila.Size = new System.Drawing.Size(655, 132);
            this.dg_pila.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_registrar,
            this.menu_eliminar,
            this.menu_reporte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_registrar
            // 
            this.menu_registrar.Name = "menu_registrar";
            this.menu_registrar.Size = new System.Drawing.Size(65, 20);
            this.menu_registrar.Text = "Registrar";
            this.menu_registrar.Click += new System.EventHandler(this.menu_registrar_Click);
            // 
            // menu_eliminar
            // 
            this.menu_eliminar.Name = "menu_eliminar";
            this.menu_eliminar.Size = new System.Drawing.Size(94, 20);
            this.menu_eliminar.Text = "Eliminar datos";
            this.menu_eliminar.Click += new System.EventHandler(this.menu_eliminar_Click);
            // 
            // menu_reporte
            // 
            this.menu_reporte.Name = "menu_reporte";
            this.menu_reporte.Size = new System.Drawing.Size(60, 20);
            this.menu_reporte.Text = "Reporte";
            this.menu_reporte.Click += new System.EventHandler(this.menu_reporte_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(324, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Formulario pila";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fecha pago";
            // 
            // dt_fecha_pago
            // 
            this.dt_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_pago.Location = new System.Drawing.Point(558, 41);
            this.dt_fecha_pago.Name = "dt_fecha_pago";
            this.dt_fecha_pago.Size = new System.Drawing.Size(131, 20);
            this.dt_fecha_pago.TabIndex = 25;
            // 
            // txt_total_recaudo
            // 
            this.txt_total_recaudo.Enabled = false;
            this.txt_total_recaudo.Location = new System.Drawing.Point(384, 408);
            this.txt_total_recaudo.Name = "txt_total_recaudo";
            this.txt_total_recaudo.Size = new System.Drawing.Size(161, 20);
            this.txt_total_recaudo.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Total recaudo";
            // 
            // txt_valor_cdt
            // 
            this.txt_valor_cdt.Location = new System.Drawing.Point(224, 69);
            this.txt_valor_cdt.Name = "txt_valor_cdt";
            this.txt_valor_cdt.Size = new System.Drawing.Size(161, 20);
            this.txt_valor_cdt.TabIndex = 29;
            this.txt_valor_cdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Valor CDT";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_valor_cdt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_total_recaudo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dt_fecha_pago);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dg_pila);
            this.Controls.Add(this.txt_valor_pagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tiempo_cdt);
            this.Controls.Add(this.com_categoria);
            this.Controls.Add(this.txt_direccion_cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nom_cliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.com_estrto);
            this.Controls.Add(this.com_mes_apertura);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.txt_numero_cdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pila";
            this.Text = "Pila";
            ((System.ComponentModel.ISupportInitialize)(this.dg_pila)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numero_cdt;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.ComboBox com_mes_apertura;
        private System.Windows.Forms.ComboBox com_estrto;
        private System.Windows.Forms.TextBox txt_nom_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_direccion_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox com_categoria;
        private System.Windows.Forms.TextBox txt_tiempo_cdt;
        private System.Windows.Forms.TextBox txt_valor_pagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_pila;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_registrar;
        private System.Windows.Forms.ToolStripMenuItem menu_eliminar;
        private System.Windows.Forms.ToolStripMenuItem menu_reporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_fecha_pago;
        private System.Windows.Forms.TextBox txt_total_recaudo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_valor_cdt;
        private System.Windows.Forms.Label label13;
    }
}