namespace ClaseObjetoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.lblResultadoEntero = new System.Windows.Forms.Label();
            this.numEntero2 = new System.Windows.Forms.NumericUpDown();
            this.numEntero1 = new System.Windows.Forms.NumericUpDown();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblResultadoDenominador = new System.Windows.Forms.Label();
            this.lblResultadoNumerador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador1.Location = new System.Drawing.Point(80, 27);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(120, 30);
            this.numNumerador1.TabIndex = 0;
            // 
            // numDenominador1
            // 
            this.numDenominador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador1.Location = new System.Drawing.Point(80, 82);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(120, 30);
            this.numDenominador1.TabIndex = 1;
            // 
            // numDenominador2
            // 
            this.numDenominador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenominador2.Location = new System.Drawing.Point(337, 82);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(120, 30);
            this.numDenominador2.TabIndex = 3;
            // 
            // numNumerador2
            // 
            this.numNumerador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumerador2.Location = new System.Drawing.Point(337, 27);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(120, 30);
            this.numNumerador2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "____________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "+";
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(484, 60);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(24, 25);
            this.lblCalcularResultado.TabIndex = 7;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // lblResultadoEntero
            // 
            this.lblResultadoEntero.AutoSize = true;
            this.lblResultadoEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEntero.Location = new System.Drawing.Point(526, 63);
            this.lblResultadoEntero.Name = "lblResultadoEntero";
            this.lblResultadoEntero.Size = new System.Drawing.Size(26, 25);
            this.lblResultadoEntero.TabIndex = 8;
            this.lblResultadoEntero.Text = "X";
            // 
            // numEntero2
            // 
            this.numEntero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero2.Location = new System.Drawing.Point(276, 55);
            this.numEntero2.Name = "numEntero2";
            this.numEntero2.Size = new System.Drawing.Size(52, 30);
            this.numEntero2.TabIndex = 9;
            // 
            // numEntero1
            // 
            this.numEntero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero1.Location = new System.Drawing.Point(12, 55);
            this.numEntero1.Name = "numEntero1";
            this.numEntero1.Size = new System.Drawing.Size(53, 30);
            this.numEntero1.TabIndex = 10;
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(220, 60);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(40, 21);
            this.cboOperacion.TabIndex = 11;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(558, 71);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(103, 13);
            this.lblLinea.TabIndex = 12;
            this.lblLinea.Text = "________________";
            this.lblLinea.Click += new System.EventHandler(this.lblLinea_Click);
            // 
            // lblResultadoDenominador
            // 
            this.lblResultadoDenominador.AutoSize = true;
            this.lblResultadoDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDenominador.Location = new System.Drawing.Point(589, 84);
            this.lblResultadoDenominador.Name = "lblResultadoDenominador";
            this.lblResultadoDenominador.Size = new System.Drawing.Size(26, 25);
            this.lblResultadoDenominador.TabIndex = 13;
            this.lblResultadoDenominador.Text = "X";
            // 
            // lblResultadoNumerador
            // 
            this.lblResultadoNumerador.AutoSize = true;
            this.lblResultadoNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNumerador.Location = new System.Drawing.Point(589, 48);
            this.lblResultadoNumerador.Name = "lblResultadoNumerador";
            this.lblResultadoNumerador.Size = new System.Drawing.Size(26, 25);
            this.lblResultadoNumerador.TabIndex = 14;
            this.lblResultadoNumerador.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.lblResultadoNumerador);
            this.Controls.Add(this.lblResultadoDenominador);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.numEntero1);
            this.Controls.Add(this.numEntero2);
            this.Controls.Add(this.lblResultadoEntero);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.Label lblResultadoEntero;
        private System.Windows.Forms.NumericUpDown numEntero2;
        private System.Windows.Forms.NumericUpDown numEntero1;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblResultadoDenominador;
        private System.Windows.Forms.Label lblResultadoNumerador;
    }
}

