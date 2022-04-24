namespace SimulacionTP4
{
    partial class Montecarlo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.btn_ejecutar_simulacion = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_cantidad_iteraciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(63, 128);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 15);
            this.lbl_desde.TabIndex = 3;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(155, 128);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(37, 15);
            this.lbl_hasta.TabIndex = 5;
            this.lbl_hasta.Text = "Hasta";
            // 
            // btn_ejecutar_simulacion
            // 
            this.btn_ejecutar_simulacion.Location = new System.Drawing.Point(689, 48);
            this.btn_ejecutar_simulacion.Name = "btn_ejecutar_simulacion";
            this.btn_ejecutar_simulacion.Size = new System.Drawing.Size(161, 52);
            this.btn_ejecutar_simulacion.TabIndex = 6;
            this.btn_ejecutar_simulacion.Text = "Ejecutar Simulación";
            this.btn_ejecutar_simulacion.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(872, 48);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(161, 52);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // lbl_cantidad_iteraciones
            // 
            this.lbl_cantidad_iteraciones.AutoSize = true;
            this.lbl_cantidad_iteraciones.Location = new System.Drawing.Point(63, 67);
            this.lbl_cantidad_iteraciones.Name = "lbl_cantidad_iteraciones";
            this.lbl_cantidad_iteraciones.Size = new System.Drawing.Size(115, 15);
            this.lbl_cantidad_iteraciones.TabIndex = 9;
            this.lbl_cantidad_iteraciones.Text = "Cantidad Iteraciones";
            // 
            // Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 678);
            this.Controls.Add(this.lbl_cantidad_iteraciones);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ejecutar_simulacion);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_desde);
            this.Name = "Montecarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Practico Nº4 - Simulación de Montecarlo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_desde;
        private Label lbl_hasta;
        private Button btn_ejecutar_simulacion;
        private Button btn_limpiar;
        private Label lbl_cantidad_iteraciones;
    }
}