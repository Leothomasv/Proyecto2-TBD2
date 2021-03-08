using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;
using Proyecto2_TBD2.Conexion;
using Proyecto2_TBD2.Tablas;


namespace Proyecto2_TBD2 { 
    public partial class PantallaPrincipal:Form {
        List<ContextMenuStrip> menus = new List<ContextMenuStrip>();
        string bd = "";
        public PantallaPrincipal() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
          
        }

        private void n_conexion_Click(object sender, EventArgs e) {
            menus.Add(Tablas);
            menus.Add(Basededatos);
            menus.Add(subMenustablas);
           
          
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            ic.Show();
        }
        public void AddConexion(String db) {
            arbol_conexiones.Nodes.Add(db);
        }

        private void añadirTablaToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

      

   

        private void eliminarTablaToolStripMenuItem_Click_1(object sender, EventArgs e) {
            
        }

       


        private void eliminarConexionToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            node.Remove();
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarDatos md = new MostrarDatos(arbol_conexiones);
            md.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        public DB2Connection obtenerConexion(string usuario) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = "db2admin";
            cn.Password = "leito123";
            cn.Database = usuario;
            cn.Server = "localhost";
            DB2Connection connect = new DB2Connection(cn.ToString());
            return connect;
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e) {
            

        }
  
        

        private void PantallaPrincipal_MdiChildActivate(object sender, EventArgs e) {
            MessageBox.Show("Hola mundo");
        }

        private void button1_Click(object sender, EventArgs e) {
            menus.Add(Tablas);
            menus.Add(Basededatos);
            menus.Add(subMenustablas);
            
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            ic.Show();
        }

       
       
       

        private void button2_Click(object sender, EventArgs e) {
            DataTable ds;
            DB2DataAdapter adapter;
            DB2Connection connection = obtenerConexion(bd);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);

                adapter = new DB2DataAdapter(cmd);
                ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                connection.Close();

            } catch (DB2Exception ex) {
                MessageBox.Show("Error !\n" + ex.Message);
            }
            connection.Close();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e) {
            bd = arbol_conexiones.SelectedNode.Text;
        }

  
    }
}
