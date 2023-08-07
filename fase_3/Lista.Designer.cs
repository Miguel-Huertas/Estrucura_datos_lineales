namespace fase_3
{
    partial class Lista
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
            this.components = new System.ComponentModel.Container();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_registro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_tipo_id = new System.Windows.Forms.ComboBox();
            this.com_estrato = new System.Windows.Forms.ComboBox();
            this.txt_num_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.dt_lista = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_si = new System.Windows.Forms.RadioButton();
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.gr_voto = new System.Windows.Forms.GroupBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).BeginInit();
            this.gr_voto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(290, 302);
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
            this.menu_registro,
            this.menu_consultar,
            this.menu_eliminar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_registro
            // 
            this.menu_registro.Name = "menu_registro";
            this.menu_registro.Size = new System.Drawing.Size(65, 20);
            this.menu_registro.Text = "Registrar";
            this.menu_registro.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // menu_consultar
            // 
            this.menu_consultar.Name = "menu_consultar";
            this.menu_consultar.Size = new System.Drawing.Size(70, 20);
            this.menu_consultar.Text = "Consultar";
            this.menu_consultar.Click += new System.EventHandler(this.menu_consultar_Click);
            // 
            // menu_eliminar
            // 
            this.menu_eliminar.Name = "menu_eliminar";
            this.menu_eliminar.Size = new System.Drawing.Size(62, 20);
            this.menu_eliminar.Text = "Eliminar";
            this.menu_eliminar.Click += new System.EventHandler(this.menu_eliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Formulario cola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo de Idenficacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Numero de Idenficacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre completo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Estrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Feha";
            // 
            // com_tipo_id
            // 
            this.com_tipo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_id.FormattingEnabled = true;
            this.com_tipo_id.Location = new System.Drawing.Point(189, 47);
            this.com_tipo_id.Name = "com_tipo_id";
            this.com_tipo_id.Size = new System.Drawing.Size(141, 21);
            this.com_tipo_id.TabIndex = 32;
            // 
            // com_estrato
            // 
            this.com_estrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_estrato.FormattingEnabled = true;
            this.com_estrato.Location = new System.Drawing.Point(441, 85);
            this.com_estrato.Name = "com_estrato";
            this.com_estrato.Size = new System.Drawing.Size(141, 21);
            this.com_estrato.TabIndex = 33;
            // 
            // txt_num_id
            // 
            this.txt_num_id.Location = new System.Drawing.Point(189, 81);
            this.txt_num_id.Name = "txt_num_id";
            this.txt_num_id.Size = new System.Drawing.Size(141, 20);
            this.txt_num_id.TabIndex = 34;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(189, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(141, 20);
            this.txt_nombre.TabIndex = 35;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(441, 52);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(141, 20);
            this.txt_edad.TabIndex = 36;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(441, 116);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(141, 20);
            this.dt_fecha.TabIndex = 37;
            // 
            // dt_lista
            // 
            this.dt_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_lista.Location = new System.Drawing.Point(66, 195);
            this.dt_lista.Name = "dt_lista";
            this.dt_lista.Size = new System.Drawing.Size(516, 87);
            this.dt_lista.TabIndex = 38;
            this.dt_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "¿Voto en las elecciones?";
            // 
            // rd_si
            // 
            this.rd_si.AutoSize = true;
            this.rd_si.Location = new System.Drawing.Point(6, 19);
            this.rd_si.Name = "rd_si";
            this.rd_si.Size = new System.Drawing.Size(35, 17);
            this.rd_si.TabIndex = 41;
            this.rd_si.TabStop = true;
            this.rd_si.Text = "SI";
            this.rd_si.UseVisualStyleBackColor = true;
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Location = new System.Drawing.Point(47, 19);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(41, 17);
            this.rd_no.TabIndex = 42;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "NO";
            this.rd_no.UseVisualStyleBackColor = true;
            // 
            // gr_voto
            // 
            this.gr_voto.Controls.Add(this.rd_no);
            this.gr_voto.Controls.Add(this.rd_si);
            this.gr_voto.Location = new System.Drawing.Point(340, 137);
            this.gr_voto.Name = "gr_voto";
            this.gr_voto.Size = new System.Drawing.Size(95, 52);
            this.gr_voto.TabIndex = 43;
            this.gr_voto.TabStop = false;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 352);
            this.Controls.Add(this.gr_voto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_lista);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_num_id);
            this.Controls.Add(this.com_estrato);
            this.Controls.Add(this.com_tipo_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lista";
            this.Text = "Lista";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).EndInit();
            this.gr_voto.ResumeLayout(false);
            this.gr_voto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_registro;
        private System.Windows.Forms.ToolStripMenuItem menu_consultar;
        private System.Windows.Forms.ToolStripMenuItem menu_eliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com_tipo_id;
        private System.Windows.Forms.ComboBox com_estrato;
        private System.Windows.Forms.TextBox txt_num_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.DataGridView dt_lista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rd_si;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.GroupBox gr_voto;
        private System.Windows.Forms.ErrorProvider error;
    }
}