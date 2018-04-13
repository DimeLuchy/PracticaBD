namespace BaseDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn = new System.Windows.Forms.Button();
            this.cmbBNombres = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn.Font = new System.Drawing.Font("AR BONNIE", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.MistyRose;
            this.btn.Location = new System.Drawing.Point(512, 179);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(239, 119);
            this.btn.TabIndex = 0;
            this.btn.Text = "Mostrar";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // cmbBNombres
            // 
            this.cmbBNombres.Font = new System.Drawing.Font("AR BONNIE", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBNombres.FormattingEnabled = true;
            this.cmbBNombres.Location = new System.Drawing.Point(431, 388);
            this.cmbBNombres.Name = "cmbBNombres";
            this.cmbBNombres.Size = new System.Drawing.Size(448, 78);
            this.cmbBNombres.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("AR BONNIE", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1116, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBNombres);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox cmbBNombres;
        private System.Windows.Forms.Button button1;
    }
}

