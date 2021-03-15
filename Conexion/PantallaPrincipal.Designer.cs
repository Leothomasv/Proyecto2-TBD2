namespace Proyecto2_TBD2 {
    partial class PantallaPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.arbol_conexiones = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Tablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_conexiones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Basededatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenustablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tablas.SuspendLayout();
            this.panel_conexiones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Basededatos.SuspendLayout();
            this.subMenustablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbol_conexiones
            // 
            this.arbol_conexiones.BackColor = System.Drawing.SystemColors.Window;
            this.arbol_conexiones.Font = new System.Drawing.Font("Verdana", 12F);
            this.arbol_conexiones.ForeColor = System.Drawing.Color.Black;
            this.arbol_conexiones.ImageIndex = 0;
            this.arbol_conexiones.ImageList = this.imageList1;
            this.arbol_conexiones.Location = new System.Drawing.Point(4, 134);
            this.arbol_conexiones.Margin = new System.Windows.Forms.Padding(4);
            this.arbol_conexiones.Name = "arbol_conexiones";
            this.arbol_conexiones.SelectedImageIndex = 0;
            this.arbol_conexiones.Size = new System.Drawing.Size(289, 717);
            this.arbol_conexiones.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_database_299089.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_File_Files_Folder_Document_Doc_Data-33_3909352.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_files-folders-35_808591.png");
            this.imageList1.Images.SetKeyName(3, "iconfinder_Key_379501.png");
            this.imageList1.Images.SetKeyName(4, "iconfinder_Process-Accept_49604.png");
            this.imageList1.Images.SetKeyName(5, "iconfinder_function_383136.png");
            this.imageList1.Images.SetKeyName(6, "iconfinder_icon-view_2867956.png");
            this.imageList1.Images.SetKeyName(7, "iconfinder_Electrical_plug_plug_plug_connector_plug_in_power_plug_4801292.png");
            this.imageList1.Images.SetKeyName(8, "iconfinder_sign-check_299110.png");
            this.imageList1.Images.SetKeyName(9, "iconfinder_system-users_118828.png");
            // 
            // Tablas
            // 
            this.Tablas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirTablaToolStripMenuItem});
            this.Tablas.Name = "menu1";
            this.Tablas.Size = new System.Drawing.Size(162, 28);
            // 
            // añadirTablaToolStripMenuItem
            // 
            this.añadirTablaToolStripMenuItem.Name = "añadirTablaToolStripMenuItem";
            this.añadirTablaToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.añadirTablaToolStripMenuItem.Text = "Añadir Tabla";
            this.añadirTablaToolStripMenuItem.Click += new System.EventHandler(this.añadirTablaToolStripMenuItem_Click);
            // 
            // panel_conexiones
            // 
            this.panel_conexiones.Controls.Add(this.button1);
            this.panel_conexiones.Controls.Add(this.refresh);
            this.panel_conexiones.Controls.Add(this.label1);
            this.panel_conexiones.Location = new System.Drawing.Point(4, 4);
            this.panel_conexiones.Margin = new System.Windows.Forms.Padding(4);
            this.panel_conexiones.Name = "panel_conexiones";
            this.panel_conexiones.Size = new System.Drawing.Size(287, 131);
            this.panel_conexiones.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(17, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 62);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(174, 61);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(65, 62);
            this.refresh.TabIndex = 2;
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexiones";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "iconfinder_sign-add_299068.png");
            this.imageList2.Images.SetKeyName(1, "iconfinder_f-cross_256_282471.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.arbol_conexiones);
            this.panel1.Controls.Add(this.panel_conexiones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1513, 855);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(857, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 86);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 276);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 576);
            this.dataGridView1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(293, 107);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1219, 167);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Basededatos
            // 
            this.Basededatos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Basededatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarConexionToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.refrescarToolStripMenuItem,
            this.seleccionarToolStripMenuItem});
            this.Basededatos.Name = "contextMenuStrip2";
            this.Basededatos.Size = new System.Drawing.Size(199, 100);
            // 
            // eliminarConexionToolStripMenuItem
            // 
            this.eliminarConexionToolStripMenuItem.Name = "eliminarConexionToolStripMenuItem";
            this.eliminarConexionToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.eliminarConexionToolStripMenuItem.Text = "Eliminar Conexion";
            this.eliminarConexionToolStripMenuItem.Click += new System.EventHandler(this.eliminarConexionToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.refrescarToolStripMenuItem_Click);
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.seleccionarToolStripMenuItem.Text = "Seleccionar";
            this.seleccionarToolStripMenuItem.Click += new System.EventHandler(this.seleccionarToolStripMenuItem_Click);
            // 
            // subMenustablas
            // 
            this.subMenustablas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subMenustablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDatosToolStripMenuItem});
            this.subMenustablas.Name = "subMenustablas";
            this.subMenustablas.Size = new System.Drawing.Size(143, 28);
            // 
            // verDatosToolStripMenuItem
            // 
            this.verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            this.verDatosToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.verDatosToolStripMenuItem.Text = "Ver Datos";
            this.verDatosToolStripMenuItem.Click += new System.EventHandler(this.verDatosToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1513, 855);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaPrincipal";
            this.Text = "IBM DB2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.PantallaPrincipal_MdiChildActivate);
            this.Tablas.ResumeLayout(false);
            this.panel_conexiones.ResumeLayout(false);
            this.panel_conexiones.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Basededatos.ResumeLayout(false);
            this.subMenustablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView arbol_conexiones;
        private System.Windows.Forms.Panel panel_conexiones;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ContextMenuStrip Tablas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem añadirTablaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Basededatos;
        private System.Windows.Forms.ToolStripMenuItem eliminarConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenustablas;
        private System.Windows.Forms.ToolStripMenuItem verDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
    }
}

