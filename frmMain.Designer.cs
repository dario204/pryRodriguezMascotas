namespace pryRodriguezMascotas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblVeterinaria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCuidar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.fotoMascota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVeterinaria
            // 
            this.lblVeterinaria.AutoSize = true;
            this.lblVeterinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinaria.Location = new System.Drawing.Point(289, 19);
            this.lblVeterinaria.Name = "lblVeterinaria";
            this.lblVeterinaria.Size = new System.Drawing.Size(242, 51);
            this.lblVeterinaria.TabIndex = 0;
            this.lblVeterinaria.Text = "Veterinaria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(39, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(39, 183);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(58, 25);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(39, 255);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(158, 25);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Mascota";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(224, 183);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(178, 22);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Caniche",
            "Gato",
            "Loro",
            "Pez",
            "Hamster"});
            this.cboTipo.Location = new System.Drawing.Point(224, 255);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(178, 24);
            this.cboTipo.TabIndex = 6;
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 16;
            this.lstMascotas.Location = new System.Drawing.Point(44, 336);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(275, 164);
            this.lstMascotas.TabIndex = 7;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(546, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 73);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Mascota";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentar.Location = new System.Drawing.Point(44, 544);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(122, 39);
            this.btnAlimentar.TabIndex = 10;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(198, 544);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(121, 39);
            this.btnJugar.TabIndex = 11;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCuidar
            // 
            this.btnCuidar.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuidar.Location = new System.Drawing.Point(44, 628);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(122, 39);
            this.btnCuidar.TabIndex = 12;
            this.btnCuidar.Text = "Cuidar";
            this.btnCuidar.UseVisualStyleBackColor = true;
            this.btnCuidar.Click += new System.EventHandler(this.btnCuidar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(720, 628);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 39);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fotoMascota
            // 
            this.fotoMascota.Image = global::pryRodriguezMascotas.Properties.Resources.pez;
            this.fotoMascota.Location = new System.Drawing.Point(546, 336);
            this.fotoMascota.Name = "fotoMascota";
            this.fotoMascota.Size = new System.Drawing.Size(284, 168);
            this.fotoMascota.TabIndex = 14;
            this.fotoMascota.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 679);
            this.Controls.Add(this.fotoMascota);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCuidar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblVeterinaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeterinaria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCuidar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox fotoMascota;
    }
}

