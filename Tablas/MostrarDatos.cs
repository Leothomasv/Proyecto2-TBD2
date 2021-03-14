using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto2_TBD2.Tablas
{
    public partial class MostrarDatos : Form
    {
        TreeView arbol_conexiones;
        DataTable ds;
        DB2DataAdapter adapter;
        public MostrarDatos(TreeView _arbol_conexiones)
        {
            InitializeComponent();
            arbol_conexiones = _arbol_conexiones;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarDatos_Load(sender, e);
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            try
            {
                tabla_name.Text = "DATOS DE TABLA : " + arbol_conexiones.SelectedNode.Text;
                PantallaPrincipal pn = new PantallaPrincipal();
                DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);

                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT * FROM " + arbol_conexiones.SelectedNode.Text + "; ", connection);
                adapter = new DB2DataAdapter(cmd);
                ds = new DataTable();
                adapter.Fill(ds);
                data_tablas.DataSource = ds;
                connection.Close();
            }
            catch (DB2Exception ex) { }
            catch { }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarTabla idt = new LlenarTabla(data_tablas, arbol_conexiones);
            idt.Show();
        }

        public void LimpiarTabla_ConMensaje()
        {
            PantallaPrincipal pn1 = new PantallaPrincipal();
            using (DB2Connection connection = pn1.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text))
            {
                try
                {
                    connection.Open();
                    DB2Command cmd = new DB2Command("TRUNCATE TABLE " + arbol_conexiones.SelectedNode.Text + " IMMEDIATE;", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tabla ha sido vaciada correctamente");
                }
                catch (DB2Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error al limpiar tabla\n" + ex.Message);
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           LimpiarTabla_ConMensaje();
           MostrarDatos_Load(sender, e);
        }
    }
}


