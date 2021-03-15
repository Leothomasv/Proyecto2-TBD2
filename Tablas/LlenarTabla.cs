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
        //Lista para datos que pueden ser null
        List<string> nulo = new List<string>();

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


            // Agregando valores a la lista de los IDS
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
           
                // Agregando tipos de datos a la lista 
                foreach (DataRow row in tabla.Rows)
                {
                    foreach (DataColumn column in tabla.Columns)
                    {
                        string tipo =(row[column]).ToString();
                        tipoDato.Add(tipo);
                    }
                }
        }


        //hace un truncate de la tabla, elimina todos los valores que se quiera
        public void LimpiarTabla_SinMensaje()
        {
            PantallaPrincipal pn1 = new PantallaPrincipal();
            using (DB2Connection connection = pn1.obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text))
            {
                try
                {
                    connection.Open();
                    DB2Command cmd = new DB2Command("TRUNCATE TABLE " + arbol_conexiones.SelectedNode.Text + " IMMEDIATE;", connection);
                    cmd.ExecuteNonQuery();
                }
                catch (DB2Exception ex)
                { 
                    MessageBox.Show("Ha ocurrido un error al limpiar tabla\n" + ex.Message);
                }
                connection.Close();
            }
        }


        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        public static string LetrasRandom()
        {
            int length = 8;
            char letter;
            lock (syncLock)
            {
                StringBuilder str_build = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                return str_build.ToString();
            }
        }

   
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public static string TrueFalse()
        {
            var opciones = new List<string> { "true", "false" };
            lock (syncLock)
            {
                int index = random.Next(opciones.Count);
                var name = opciones[index];
                opciones.RemoveAt(index);
                return name;
            }
        }

        private void confirmarButton_Click(object sender, EventArgs e){

            LimpiarTabla_SinMensaje();
            var watch = new System.Diagnostics.Stopwatch();

            string ids = "";
            string values = "";

            int cant = 0;
            cant = Int32.Parse(cantReg.Text); //cantidad de registros que se desean ingresar

            string dat = tipoDato[0].ToString();

            string inte = "INTEGER ";
            string var = "VARCHAR ";
            string boleano = "BOOLEAN ";
            string dec = "DECIMAL ";
            string dou = "DOUBLE ";

            string query ="";

            bool entroUnaColumna = false;
            bool entroMasColumna = false;


            //este es para sacar el progress bar
           
                if(entroUnaColumna == false  || entroMasColumna == false) { //cambiar por un for para ver si se pueden ingresar mas de una tabla
                    //este es si solo tengo un campo

                    if (id.Count == 1 && entroMasColumna == false) // si ya entro a la primera iteracion que tiene mas de una columna aqui no entra!!!!!
                    {
                        watch.Start(); // tiempo inicia
                            if (entroUnaColumna == false)
                            {
                                ids += id[0];
                            }
                            if (dat.Equals(inte)) //INTEGER
                            {
                                string numero = "";
                                listBox1.Items.Add("Iniciando llenado de tabla: " + arbol_conexiones.SelectedNode.Text);

                                for (int l = 1; l <= cant; l++)
                                {
                                    entroUnaColumna = true;
                                    numero = RandomNumber(1, 1000000).ToString();
                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + "'" + numero + "'" + ");";
                                    listBox1.Items.Add("Ingresando dato: " + l);
                                    ingresar(query);
                                    query = "";
                                    numero = "";
                                    if (progressBar.Value < 100)
                                    {
                                        progressBar.Value++;
                                    }
                                }
                                
                            }
                            else if(dat.Equals(var)) //VARCHAR
                            {
                                string letra = "";
                                listBox1.Items.Add("Iniciando llenado de tabla: " + arbol_conexiones.SelectedNode.Text);
                                for (int a =1; a <= cant; a++)
                                {
                                    entroUnaColumna = true;
                                    letra = LetrasRandom();
                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + "'" + letra + "'" + ");";
                                    listBox1.Items.Add("Ingresando dato: " + a);
                                    ingresar(query);
                                    query = "";
                                    letra = "";
                                    if (progressBar.Value < 100)
                                    {
                                    progressBar.Value++;
                                    }
                                }
                            }
                            else if (dat.Equals(boleano)) //BOOLEANO
                            {
                                string op = "";
                                listBox1.Items.Add("Iniciando llenado de tabla: " + arbol_conexiones.SelectedNode.Text);
                                for (int a = 1; a <= cant; a++)
                                {
                                    entroUnaColumna = true;
                                    op = TrueFalse();
                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + "'" + op + "'" + ");";
                                    listBox1.Items.Add("Ingresando dato: " + a);
                                    ingresar(query);
                                    query = "";
                                    op = "";
                                    if (progressBar.Value < 100)
                                    {
                                        progressBar.Value++;
                                    }
                                }
                            }
                         watch.Stop(); //tiempo termina
                    }//fin if

                    //Listas para datos
                    List<string> datos = new List<string>();
                    string nombreDato = "";
                    int x = 0;
                    int y = 0;
                   int datoIngresado = 0;


                    if (id.Count > 1)
                    {
                        watch.Start();
                        listBox1.Items.Add("Iniciando llenado de tabla: " + arbol_conexiones.SelectedNode.Text);
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
                                    nombreDato = datos[x]; // con esto se obtienen la cantidad de tipos de datos y asi poder hacer la comparacion en que ciclo va a ingresar por ejemplo varchar boolean int etc

                                    if (y < (tipoDato.Count - 1))
                                    {
                                        if (nombreDato.Equals(inte))//INTEGER
                                        {
                                            values += "'" + RandomNumber(1, 10000).ToString() + "',";
                                            x++;
                                            y++;
                                        }else if(nombreDato.Equals(var))//VARCHAR
                                        {
                                            values += "'" + LetrasRandom() + "',";
                                            x++; 
                                            y++;
                                        }else if (nombreDato.Equals(boleano)) //BOOLEAN
                                        {
                                            values += "'" + TrueFalse() + "',";
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
                                            values += "'" + LetrasRandom() + "'";
                                            x++;
                                            y++;
                                        }
                                        else if (nombreDato.Equals(boleano)) //BOOLEAN
                                        {
                                            values += "'" + TrueFalse() + "'";
                                            x++;
                                            y++;
                                        }
                                    }

                                    query = "INSERT INTO " + arbol_conexiones.SelectedNode.Text + " (" + ids + ") VALUES (" + values + ");";

                                    if (x == tipoDato.Count) //una vez se hayan completado la cantidad de datos y el query este hecho se ingresa a la base de datos
                                    {
                                        datoIngresado++;
                                        ingresar2(query);
                                        listBox1.Items.Add("Ingresando dato: " + datoIngresado);
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
                       watch.Stop();
                    }

                }
            listBox1.Items.Add("Proceso Terminado!!!");
            MessageBox.Show("Datos Ingresados Correctamente" +"\n"+ $"Execution Time: {watch.ElapsedMilliseconds*0.001} segundos");
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
