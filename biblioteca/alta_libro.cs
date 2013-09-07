using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace biblioteca
{
    public partial class alta_libro : Form
    {
        public alta_libro()
        {
            InitializeComponent();
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdguardar_Click(object sender, EventArgs e)
        {
            //creamos el objeto que establece la conexión 
            //con el servidor sql
            SqlConnection miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data Source=NBRAR\\SQLEXPRESS2008 ";
            miConexion.ConnectionString += ";Initial catalog=Biblioteca_pasantias_2013 ";
            miConexion.ConnectionString += ";User Id=sa ";
            miConexion.ConnectionString += ";Password=123 ";
            miConexion.Open();
            //creamos el objeto que nos permitirá enviar un
            //comando sql al servidor
            SqlCommand miComando = new SqlCommand();
            //establecemos en la propiedad Connection que use
            //el objeto Sqlconnection que hemos creado más
            //arriba
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandText = "dbo.insertar_libro";

            //armamos los parametros que enviaremos al 
            //procedimiento almacenado 
            SqlParameter paramNombre = new SqlParameter();
            paramNombre.ParameterName = "@nom";
            paramNombre.SqlDbType = SqlDbType.VarChar;
            paramNombre.Value = txtnombre.Text;

            SqlParameter paramPaginas = new SqlParameter();
            paramPaginas.ParameterName = "@pag";
            paramPaginas.SqlDbType = SqlDbType.SmallInt;
            paramPaginas.Value = Convert.ToInt16(txtpaginas.Text);

            SqlParameter paramIsbn = new SqlParameter();
            paramIsbn.ParameterName = "@isb";
            paramIsbn.SqlDbType = SqlDbType.VarChar;
            paramIsbn.Value = txtisbn.Text;

            //agregamos los parametros a miComando 

            miComando.Parameters.Add(paramNombre);
            miComando.Parameters.Add(paramPaginas);
            miComando.Parameters.Add(paramIsbn);

            //ejecutamos miComando

            miComando.ExecuteNonQuery();







        }
    }
}
