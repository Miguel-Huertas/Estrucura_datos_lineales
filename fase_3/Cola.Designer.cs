namespace fase_3
{
    partial class Cola
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.com_comuna = new System.Windows.Forms.ComboBox();
            this.com_genero = new System.Windows.Forms.ComboBox();
            this.dg_cola = new System.Windows.Forms.DataGridView();
            this.txt_total_registros = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cola)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(656, 290);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "Regresar menu ";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_registrar,
            this.menu_eliminar,
            this.menu_reporte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_registrar
            // 
            this.menu_registrar.Name = "menu_registrar";
            this.menu_registrar.Size = new System.Drawing.Size(65, 20);
            this.menu_registrar.Text = "Registrar";
            this.menu_registrar.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(280, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Formulario cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Comuna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total registros ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(167, 55);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(186, 20);
            this.txt_id.TabIndex = 31;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(167, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(186, 20);
            this.txt_nombre.TabIndex = 32;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(167, 118);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(186, 20);
            this.txt_direccion.TabIndex = 33;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(456, 115);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(132, 20);
            this.dt_fecha.TabIndex = 34;
            // 
            // com_comuna
            // 
            this.com_comuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_comuna.FormattingEnabled = true;
            this.com_comuna.Location = new System.Drawing.Point(456, 62);
            this.com_comuna.Name = "com_comuna";
            this.com_comuna.Size = new System.Drawing.Size(158, 21);
            this.com_comuna.TabIndex = 35;
            // 
            // com_genero
            // 
            this.com_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_genero.FormattingEnabled = true;
            this.com_genero.Location = new System.Drawing.Point(456, 87);
            this.com_genero.Name = "com_genero";
            this.com_genero.Size = new System.Drawing.Size(158, 21);
            this.com_genero.TabIndex = 36;
            // 
            // dg_cola
            // 
            this.dg_cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cola.Location = new System.Drawing.Point(54, 144);
            this.dg_cola.Name = "dg_cola";
            this.dg_cola.Size = new System.Drawing.Size(560, 134);
            this.dg_cola.TabIndex = 37;
            // 
            // txt_total_registros
            // 
            this.txt_total_registros.Enabled = false;
            this.txt_total_registros.Location = new System.Drawing.Point(167, 283);
            this.txt_total_registros.Name = "txt_total_registros";
            this.txt_total_registros.Size = new System.Drawing.Size(186, 20);
            this.txt_total_registros.TabIndex = 38;
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 320);
            this.Controls.Add(this.txt_total_registros);
            this.Controls.Add(this.dg_cola);
            this.Controls.Add(this.com_genero);
            this.Controls.Add(this.com_comuna);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cola";
            this.Text = "Cola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_registrar;
        private System.Windows.Forms.ToolStripMenuItem menu_eliminar;
        private System.Windows.Forms.ToolStripMenuItem menu_reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.ComboBox com_comuna;
        private System.Windows.Forms.ComboBox com_genero;
        private System.Windows.Forms.DataGridView dg_cola;
        private System.Windows.Forms.TextBox txt_total_registros;
    }
}