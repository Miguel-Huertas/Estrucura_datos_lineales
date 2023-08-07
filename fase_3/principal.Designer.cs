namespace fase_3
{
    partial class principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pila = new System.Windows.Forms.Button();
            this.btn_cola = new System.Windows.Forms.Button();
            this.btn_lista = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESTRUCURA DE DATOS LINEALES ";
            // 
            // btn_pila
            // 
            this.btn_pila.Location = new System.Drawing.Point(63, 164);
            this.btn_pila.Name = "btn_pila";
            this.btn_pila.Size = new System.Drawing.Size(75, 23);
            this.btn_pila.TabIndex = 8;
            this.btn_pila.Text = "Pila";
            this.btn_pila.UseVisualStyleBackColor = true;
            this.btn_pila.Click += new System.EventHandler(this.btn_pila_Click);
            // 
            // btn_cola
            // 
            this.btn_cola.Location = new System.Drawing.Point(229, 164);
            this.btn_cola.Name = "btn_cola";
            this.btn_cola.Size = new System.Drawing.Size(75, 23);
            this.btn_cola.TabIndex = 9;
            this.btn_cola.Text = "Cola";
            this.btn_cola.UseVisualStyleBackColor = true;
            this.btn_cola.Click += new System.EventHandler(this.btn_cola_Click);
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(393, 164);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(75, 23);
            this.btn_lista.TabIndex = 10;
            this.btn_lista.Text = "Lista";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(229, 255);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingenieria de sistemas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Luis Miguel Huertas ";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.btn_cola);
            this.Controls.Add(this.btn_pila);
            this.Controls.Add(this.label1);
            this.Name = "principal";
            this.Text = "principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pila;
        private System.Windows.Forms.Button btn_cola;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}