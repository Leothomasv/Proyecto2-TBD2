namespace Proyecto2_TBD2.Conexion {
    partial class IngresarConexion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarConexion));
            this.usuario = new System.Windows.Forms.TextBox();
            this.name_db = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(236, 251);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(132, 22);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "db2admin";
            // 
            // name_db
            // 
            this.name_db.Location = new System.Drawing.Point(236, 70);
            this.name_db.Margin = new System.Windows.Forms.Padding(4);
            this.name_db.Name = "name_db";
            this.name_db.Size = new System.Drawing.Size(132, 22);
            this.name_db.TabIndex = 1;
            this.name_db.Text = "SAMPLE";
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(236, 305);
            this.contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(132, 22);
            this.contrasena.TabIndex = 2;
            this.contrasena.Text = "leito123";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(236, 122);
            this.server.Margin = new System.Windows.Forms.Padding(4);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(132, 22);
            this.server.TabIndex = 3;
            this.server.Text = "localhost";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(192, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(421, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 83);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(80, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(60, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Base de datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(63, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrasena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F);
            this.label4.Location = new System.Drawing.Point(88, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Servidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(231, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connections";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(265, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Log In";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(236, 169);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(132, 22);
            this.port.TabIndex = 12;
            this.port.Text = "50000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(88, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Puerto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 129);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // IngresarConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.server);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.name_db);
            this.Controls.Add(this.usuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresarConexion";
            this.Text = "IngresarConexion";
            this.Load += new System.EventHandler(this.IngresarConexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox name_db;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}