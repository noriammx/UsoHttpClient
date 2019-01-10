namespace SubirEvidencias
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnUpLoadOneFile = new System.Windows.Forms.Button();
            this.btnMultipleFiles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCargarMultiples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar Archivo:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(167, 15);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(351, 20);
            this.txtNombreArchivo.TabIndex = 1;
            // 
            // btnUpLoadOneFile
            // 
            this.btnUpLoadOneFile.Location = new System.Drawing.Point(369, 41);
            this.btnUpLoadOneFile.Name = "btnUpLoadOneFile";
            this.btnUpLoadOneFile.Size = new System.Drawing.Size(149, 23);
            this.btnUpLoadOneFile.TabIndex = 0;
            this.btnUpLoadOneFile.Text = "Cargar";
            this.btnUpLoadOneFile.UseVisualStyleBackColor = true;
            this.btnUpLoadOneFile.Click += new System.EventHandler(this.btnUpLoadOneFile_Click);
            // 
            // btnMultipleFiles
            // 
            this.btnMultipleFiles.Location = new System.Drawing.Point(12, 91);
            this.btnMultipleFiles.Name = "btnMultipleFiles";
            this.btnMultipleFiles.Size = new System.Drawing.Size(149, 23);
            this.btnMultipleFiles.TabIndex = 0;
            this.btnMultipleFiles.Text = "Seleccionar Archivos:";
            this.btnMultipleFiles.UseVisualStyleBackColor = true;
            this.btnMultipleFiles.Click += new System.EventHandler(this.btnMultipleFiles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(167, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btnCargarMultiples
            // 
            this.btnCargarMultiples.Location = new System.Drawing.Point(369, 192);
            this.btnCargarMultiples.Name = "btnCargarMultiples";
            this.btnCargarMultiples.Size = new System.Drawing.Size(149, 23);
            this.btnCargarMultiples.TabIndex = 0;
            this.btnCargarMultiples.Text = "Cargar";
            this.btnCargarMultiples.UseVisualStyleBackColor = true;
            this.btnCargarMultiples.Click += new System.EventHandler(this.btnCargarMultiples_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 237);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnCargarMultiples);
            this.Controls.Add(this.btnUpLoadOneFile);
            this.Controls.Add(this.btnMultipleFiles);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ejemplo de Uso de HTTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnUpLoadOneFile;
        private System.Windows.Forms.Button btnMultipleFiles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCargarMultiples;
    }
}

