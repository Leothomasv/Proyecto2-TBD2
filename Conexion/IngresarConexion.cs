using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace Proyecto2_TBD2.Conexion {
    public partial class IngresarConexion:Form {
        TreeView arbol;
        List<ContextMenuStrip> subMenus;
        TreeNode node1;
        
        public IngresarConexion(TreeView _arbol, List<ContextMenuStrip> _subMenus) {
            arbol = _arbol;
            subMenus = _subMenus;
            InitializeComponent();
        }

        private void IngresarConexion_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = usuario.Text;
            cn.Password = contrasena.Text;
            cn.Database = name_db.Text;
            cn.Server = server.Text;
            DB2Connection connect = new DB2Connection(cn.ToString());
            try {
                connect.Open();
                //MessageBox.Show("Conexion Exitosa!\n" + "Version servidor: " + connect.ServerVersion + " Base de datos: " + connect.Database.ToString());
            } catch (DB2Exception error) {
                MessageBox.Show("A ocurrido un error!\n" + error.Message);
            }
            connect.Close();
        }

      

        private void button2_Click(object sender, EventArgs e) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = usuario.Text;
            cn.Password = contrasena.Text;
            cn.Database = name_db.Text;
            cn.Server = server.Text;
            DB2Connection connect = new DB2Connection(cn.ToString());
            try {
                connect.Open();
               // MessageBox.Show("Conexion Exitosa!\n" + "Version servidor: " + connect.ServerVersion + " Base de datos: " + connect.Database.ToString());
                CrearConexion(cn.Database);
                obtenerTablas(connect);
                
                this.Hide();
            } catch (DB2Exception error) {
                MessageBox.Show("A ocurrido un error!\n" + error.Message);
            }

            connect.Close();
         
        }
        public void Refrescar(string db) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = "db2admin";
            cn.Password = "leito123";
            cn.Database = db;
            cn.Server = "localhost";
            DB2Connection connect = new DB2Connection(cn.ToString());
            try {
                connect.Open();
                CrearConexion(cn.Database);
                obtenerTablas(connect);
            } catch (DB2Exception error) {
                MessageBox.Show("A ocurrido un error!\n" + error.Message);
            }

            connect.Close();
        }

        public void obtenerTablas(DB2Connection connect) {
            DB2Command cmd = new DB2Command("SELECT NAME FROM SYSIBM.SYSTABLES WHERE type = 'T' AND creator = '" + usuario.Text.ToUpper()+"';", connect);//OBTENER TABLAS DE LA BASE DE DATOS
            DB2DataReader bff = cmd.ExecuteReader();
            while (bff.Read()) {
                var Names = bff ["NAME"].ToString();
                TreeNode nodo = node1.Nodes.Add(Names.ToString());
                nodo.ImageIndex = 2;
                nodo.SelectedImageIndex = 2;
                nodo.ContextMenuStrip = subMenus [2];
            }
            bff.Close();
        }


        public void CrearConexion(string db) {
            TreeNode node0 = arbol.Nodes.Add(db);
            node0.ContextMenuStrip = subMenus [1];

            node1 = node0.Nodes.Add("Tablas");
            node1.ImageIndex = 1;
            node1.SelectedImageIndex = 1;
            node1.ContextMenuStrip = subMenus[0];

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


