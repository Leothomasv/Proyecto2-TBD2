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

namespace Proyecto2_TBD2.Tablas
{
    public partial class LlenarTabla : Form
    {
        DataGridView data_tablas;
        TreeView arbol_conexiones;

        //Lista para sacar el tipo de dato
        List<string> tipoDato = new List<string>();
        //Lista para sacar el id
        List<string> id = new List<string>();
        public LlenarTabla(DataGridView data,TreeView arbol)
        {
            InitializeComponent();
            data_tablas = data;
            arbol_conexiones = arbol;
        }

        private void LlenarTabla_Load(object sender, EventArgs e)
        {
            //Sacar los ids

            DataTable tabla1 = new DataTable();
            PantallaPrincipal pn1 = new PantallaPrincipal();
            using (DB2Connection connection = pn1.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text))
            {
                try
                {
                    connection.Open();
                    DB2Command cmd = new DB2Command("SELECT NAME FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '" + arbol_conexiones.SelectedNode.Text + "';", connection);
                    DB2DataAdapter data = new DB2DataAdapter(cmd);

                    data.Fill(tabla1);
                    dataGridView2.DataSource = tabla1;
                }
                catch (DB2Exception ex)
                { }
                connection.Close();
            }


            // For each row, print the values of each column.
            foreach (DataRow row in tabla1.Rows)
            {
                foreach (DataColumn column in tabla1.Columns)
                {
                    string name = (row[column]).ToString();
                    id.Add(name);
                }
            }

            //Sacar tipo de dato
            DataTable tabla = new DataTable();
            PantallaPrincipal pn = new PantallaPrincipal();
            using (DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text))
            {
                try
                {
                    connection.Open();
                    DB2Command cmd = new DB2Command("SELECT COLTYPE FROM SYSIBM.SYSCOLUMNS WHERE TBNAME = '" + arbol_conexiones.SelectedNode.Text + "';", connection);
                    DB2DataAdapter data = new DB2DataAdapter(cmd);
                   
                    data.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                catch (DB2Exception ex)
                {}
                connection.Close();
            }
           
                // For each row, print the values of each column.
                foreach (DataRow row in tabla.Rows)
                {
                    foreach (DataColumn column in tabla.Columns)
                    {
                        string tipo =(row[column]).ToString();
                        tipoDato.Add(tipo);
                    }
                }
        }


        //datos random
        // int rand_num;
        // string rand_palabra;
    

        public string GenerarRandomLetters()
        {
            int length = 5;

            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

                for (int i = 0; i < length; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                //System.Console.WriteLine(str_build.ToString());
            return str_build.ToString();
        }



        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }


        
        private void confirmarButton_Click(object sender, EventArgs e){

            string ids = "";
            string values = "";

            int cant = 0;
            cant = Int32.Parse(cantReg.Text);

            string dat = tipoDato[0].ToString();

            string inte = "INTEGER ";
            string var = "VARCHAR ";

            string query ="";

            bool entroUnaColumna = false;
            bool entroMasColumna = false;

            //este es para sacar el progress bar
           
                if(entroUnaColumna == false  || entroMasColumna == false) {
                    //este es si solo tengo un campo
                    if (id.Count == 1 && entroMasColumna == false) // si ya entro a la primera iteracion que tiene mas de una columna aqui no entra!!!!!
                    {
                            if (entroUnaColumna == false)
                            {
                                ids += id[0];
                            }
                            if (dat.Equals(inte)) //INTEGER
                            {
                                string numero = "";
                            
                                for (int l = 1; l <= cant; l++)
                                {
                                    entroUnaColumna = true;
                                    numero = RandomNumber(1, 1000000).ToString();
                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + "'" + numero + "'" + ");";
                                    ingresar(query);
                                    query = "";
                                    numero = "";
                                    if (progressBar.Value < 100)
                                    {
                                        progressBar.Value++;
                                    }
                                }
                                
                            }
                            else  //VARCHAR
                            {
                                string letra = "";
                                for(int a =1; a <= cant; a++)
                                {
                                    entroUnaColumna = true;
                                    letra = GenerarRandomLetters();
                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + "'" + letra + "'" + ");";
                                    ingresar(query);
                                    query = "";
                                    letra = "";
                                    if (progressBar.Value < 100)
                                    {
                                    progressBar.Value++;
                                    }
                                }
                            }
                    }//fin if

                //Listas para datos
                List<string> datos = new List<string>();
                string nombreDato = "";
                int x = 0;
                int y = 0;

                if (id.Count > 1)
                    {
                        if (entroMasColumna == false)
                        {
                            for (int i = 0; i < id.Count; i++)
                            {

                                if (i < (id.Count - 1))//entra aqui si hay mas de un id
                                {
                                    ids += id[i] + ",";
                                    datos.Add(tipoDato[i]);
                                }
                                else // entra aqui si solo queda un id
                                {
                                    ids += id[i];
                                    datos.Add(tipoDato[i]);
                                }
                            }
                        }
                             
                    for (int u =1; u<= cant*tipoDato.Count; u++)
                        {
                            entroMasColumna = true;
                            nombreDato = datos[x];

                            if (y < (tipoDato.Count - 1))
                            {
                                if (nombreDato.Equals(inte))//INTEGER
                                {
                                    values += "'" + RandomNumber(1, 10000).ToString() + "',";
                                    x++;
                                    y++;
                                }else if(nombreDato.Equals(var))//VARCHAR
                                {
                                    values += "'" + GenerarRandomLetters() + "',";
                                    x++; 
                                    y++;
                                }
                            }
                            else 
                            {
                                if (nombreDato.Equals(inte))//INTEGER
                                {
                                    values += "'" + RandomNumber(1, 10000).ToString() + "'";
                                    x++;
                                    y++;
                                }
                                else if (nombreDato.Equals(var))//VARCHAR
                                {
                                    values += "'" + GenerarRandomLetters() + "'";
                                    x++;
                                    y++;
                                }
                            }
                            query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + values + ");";
                            if (x == tipoDato.Count)
                            {
                                ingresar2(query);
                                x = 0;
                                y = 0;
                                query = "";
                                values="";
                            }
                        if (progressBar.Value < 100)
                        {
                            progressBar.Value++;
                        }
                    }

                    }

                }
            MessageBox.Show("Datos Ingresados Correctamente");
        }// fin de funcion click




        public void ingresar(string q)
        {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try
            {
                connection.Open();
                DB2Command cmd = new DB2Command(q, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Registro insertado correctamente");
            }
            catch (DB2Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al insertar\n" + ex.Message);
            }
            connection.Close();
        }

        public void ingresar2(string q)
        {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try
            {
                connection.Open();
                DB2Command cmd = new DB2Command(q, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Registro insertado correctamente");
            }
            catch (DB2Exception ex)
            {
                //MessageBox.Show("Ha ocurrido un error al insertar\n" + ex.Message);
            }
            connection.Close();
        }
    }
}
