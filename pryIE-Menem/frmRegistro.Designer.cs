namespace pryIE_Menem
{
    partial class frmRegistro
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblNExp = new System.Windows.Forms.Label();
            this.lblJusg = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.txtNExp = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.cboJusg = new System.Windows.Forms.ComboBox();
            this.cboLiquidador = new System.Windows.Forms.ComboBox();
            this.cboJurisdiccion = new System.Windows.Forms.ComboBox();
            this.lblJuris = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(157, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(91, 21);
            this.txtNumero.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 46);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 15);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Nº";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(157, 85);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(206, 21);
            this.txtEntidad.TabIndex = 2;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(20, 85);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(44, 15);
            this.lblEntidad.TabIndex = 3;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(20, 122);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(51, 15);
            this.lblApertura.TabIndex = 4;
            this.lblApertura.Text = "Apertura";
            // 
            // lblNExp
            // 
            this.lblNExp.AutoSize = true;
            this.lblNExp.Location = new System.Drawing.Point(20, 164);
            this.lblNExp.Name = "lblNExp";
            this.lblNExp.Size = new System.Drawing.Size(75, 15);
            this.lblNExp.TabIndex = 6;
            this.lblNExp.Text = "Nº Expediente";
            // 
            // lblJusg
            // 
            this.lblJusg.AutoSize = true;
            this.lblJusg.Location = new System.Drawing.Point(393, 43);
            this.lblJusg.Name = "lblJusg";
            this.lblJusg.Size = new System.Drawing.Size(31, 15);
            this.lblJusg.TabIndex = 7;
            this.lblJusg.Text = "Jusg.";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(393, 164);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(53, 15);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(393, 128);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(123, 15);
            this.lblLiquidador.TabIndex = 9;
            this.lblLiquidador.Text = "Liquidador Responsable";
            this.lblLiquidador.Click += new System.EventHandler(this.lblLiquidador_Click);
            // 
            // txtNExp
            // 
            this.txtNExp.Location = new System.Drawing.Point(157, 158);
            this.txtNExp.Name = "txtNExp";
            this.txtNExp.Size = new System.Drawing.Size(158, 21);
            this.txtNExp.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(470, 161);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(190, 21);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.dtpApertura);
            this.mrcDatos.Controls.Add(this.cboJusg);
            this.mrcDatos.Controls.Add(this.cboLiquidador);
            this.mrcDatos.Controls.Add(this.cboJurisdiccion);
            this.mrcDatos.Controls.Add(this.lblJuris);
            this.mrcDatos.Controls.Add(this.txtNumero);
            this.mrcDatos.Controls.Add(this.txtDireccion);
            this.mrcDatos.Controls.Add(this.lblNumero);
            this.mrcDatos.Controls.Add(this.txtEntidad);
            this.mrcDatos.Controls.Add(this.txtNExp);
            this.mrcDatos.Controls.Add(this.lblEntidad);
            this.mrcDatos.Controls.Add(this.lblLiquidador);
            this.mrcDatos.Controls.Add(this.lblApertura);
            this.mrcDatos.Controls.Add(this.lblDireccion);
            this.mrcDatos.Controls.Add(this.lblJusg);
            this.mrcDatos.Controls.Add(this.lblNExp);
            this.mrcDatos.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatos.Location = new System.Drawing.Point(12, 51);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(683, 216);
            this.mrcDatos.TabIndex = 14;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos Proveedor";
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(157, 122);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(200, 21);
            this.dtpApertura.TabIndex = 18;
            // 
            // cboJusg
            // 
            this.cboJusg.FormattingEnabled = true;
            this.cboJusg.Location = new System.Drawing.Point(516, 46);
            this.cboJusg.Name = "cboJusg";
            this.cboJusg.Size = new System.Drawing.Size(144, 23);
            this.cboJusg.TabIndex = 17;
            // 
            // cboLiquidador
            // 
            this.cboLiquidador.FormattingEnabled = true;
            this.cboLiquidador.Location = new System.Drawing.Point(516, 125);
            this.cboLiquidador.Name = "cboLiquidador";
            this.cboLiquidador.Size = new System.Drawing.Size(144, 23);
            this.cboLiquidador.TabIndex = 16;
            // 
            // cboJurisdiccion
            // 
            this.cboJurisdiccion.FormattingEnabled = true;
            this.cboJurisdiccion.Location = new System.Drawing.Point(516, 83);
            this.cboJurisdiccion.Name = "cboJurisdiccion";
            this.cboJurisdiccion.Size = new System.Drawing.Size(144, 23);
            this.cboJurisdiccion.TabIndex = 15;
            // 
            // lblJuris
            // 
            this.lblJuris.AutoSize = true;
            this.lblJuris.Location = new System.Drawing.Point(396, 85);
            this.lblJuris.Name = "lblJuris";
            this.lblJuris.Size = new System.Drawing.Size(64, 15);
            this.lblJuris.TabIndex = 14;
            this.lblJuris.Text = "Jurisdiccion";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(716, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(714, 114);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(714, 67);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(714, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(227, 9);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(382, 32);
            this.lblRegistros.TabIndex = 19;
            this.lblRegistros.Text = "Registrar Datos del Proveedor";
            this.lblRegistros.Click += new System.EventHandler(this.lblRegistros_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 273);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(777, 227);
            this.dgvProveedores.TabIndex = 20;
            this.dgvProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apertura";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº Expte.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Juzg.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jurisd";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Direccion";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Liquidador Responsable";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(803, 514);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcDatos);
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblNExp;
        private System.Windows.Forms.Label lblJusg;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.TextBox txtNExp;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblJuris;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.ComboBox cboJurisdiccion;
        private System.Windows.Forms.ComboBox cboLiquidador;
        private System.Windows.Forms.ComboBox cboJusg;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}