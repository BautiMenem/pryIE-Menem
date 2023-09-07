namespace pryIE_Menem
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadoRep = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblUser2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gestion,
            this.ListadoRep});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(572, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora,
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 17);
            this.lblHora.Text = "Hora";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(505, 3, 10, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Interval = 1000;
            this.hora.Tick += new System.EventHandler(this.hora_Tick_1);
            // 
            // Gestion
            // 
            this.Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem});
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(59, 20);
            this.Gestion.Text = "Gestión";
            this.Gestion.Click += new System.EventHandler(this.Gestion_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProveedoresToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeProveedoresToolStripMenuItem.Text = "Registro de Proveedores";
            // 
            // ListadoRep
            // 
            this.ListadoRep.Name = "ListadoRep";
            this.ListadoRep.Size = new System.Drawing.Size(114, 20);
            this.ListadoRep.Text = "Listado / Reportes";
            // 
            // lblUser
            // 
            this.lblUser.Margin = new System.Windows.Forms.Padding(490, 3, 0, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 17);
            this.lblUser.Text = "User";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 343);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(572, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblUser2
            // 
            this.lblUser2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(118, 17);
            this.lblUser2.Tag = "trdfgdgd";
            this.lblUser2.Text = "toolStripStatusLabel2";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(572, 387);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProSeg - Broker de Seguros ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripMenuItem Gestion;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListadoRep;
        public System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.StatusStrip statusStrip2;
        public System.Windows.Forms.ToolStripStatusLabel lblUser2;
    }
}

