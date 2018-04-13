using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=PracticaVisual; Uid=root;pwd= ;");
            try
            {
                cmbBNombres.Text = "Nombres";
                cmbBNombres.Items.Clear();
                conectar.Open();

                MySqlCommand comando = new MySqlCommand("Select nombre from alumno", conectar);// objeto que establezca la conexion
                MySqlDataReader almacena = comando.ExecuteReader();//ejecutara y almacenara los datos del codigo de arriba

                while (almacena.Read())//mientras exista algo que leer
                {
                    cmbBNombres.Refresh();
                    cmbBNombres.Items.Add(almacena.GetValue(0).ToString());//Se agregan los items al combo box
                }
                conectar.Close();// todo open debe cerrar
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
