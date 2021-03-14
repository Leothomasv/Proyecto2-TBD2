
namespace Proyecto2_TBD2.Tablas
{
    partial class MostrarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarDatos));
            this.control_tabla = new System.Windows.Forms.TabControl();
            this.Datos = new System.Windows.Forms.TabPage();
            this.data_tablas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabla_name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.control_tabla.SuspendLayout();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // control_tabla
            // 
            this.control_tabla.Controls.Add(this.Datos);
            this.control_tabla.Font = new System.Drawing.Font("Verdana", 12F);
            this.control_tabla.Location = new System.Drawing.Point(13, 106);
            this.control_tabla.Margin = new System.Windows.Forms.Padding(4);
            this.control_tabla.Name = "control_tabla";
            this.control_tabla.SelectedIndex = 0;
            this.control_tabla.Size = new System.Drawing.Size(867, 653);
            this.control_tabla.TabIndex = 1;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.data_tablas);
            this.Datos.Location = new System.Drawing.Point(4, 34);
            this.Datos.Margin = new System.Windows.Forms.Padding(4);
            this.Datos.Name = "Datos";
            this.Datos.Padding = new System.Windows.Forms.Padding(4);
            this.Datos.Size = new System.Drawing.Size(859, 615);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = true;
            // 
            // data_tablas
            // 
            this.data_tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_tablas.Location = new System.Drawing.Point(4, 4);
            this.data_tablas.Margin = new System.Windows.Forms.Padding(4);
            this.data_tablas.Name = "data_tablas";
            this.data_tablas.RowHeadersWidth = 51;
            this.data_tablas.Size = new System.Drawing.Size(851, 607);
            this.data_tablas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1099, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabla_name
            // 
            this.tabla_name.AutoSize = true;
            this.tabla_name.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabla_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabla_name.Location = new System.Drawing.Point(450, 45);
            this.tabla_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabla_name.Name = "tabla_name";
            this.tabla_name.Size = new System.Drawing.Size(73, 25);
            this.tabla_name.TabIndex = 7;
            this.tabla_name.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(945, 259);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar Datos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(988, 669);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(945, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar Tabla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabla_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.control_tabla);
            this.Name = "MostrarDatos";
            this.Text = "MostrarDatos";
            this.Load += new System.EventHandler(this.MostrarDatos_Load);
            this.control_tabla.ResumeLayout(false);
            this.Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_tablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl control_tabla;
        private System.Windows.Forms.TabPage Datos;
        private System.Windows.Forms.DataGridView data_tablas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tabla_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}