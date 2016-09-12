using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Forms
using System.Data.SqlClient; //BD
namespace Examen_final_proga2_marjorie
{
    class matriculadelaU
    { //una variable de conexion

        SqlConnection miconexion;

        public void conectar()
        {
            //instanciamos el objeto conexion
            miconexion = new SqlConnection("Data Source=M;Initial Catalog=MatriUH;Integrated Security=True");
            miconexion.Open();

        }

        public void desconectar()
        {
            miconexion.Close();
        }


        public void ejecutarsql(String query)
        {
            //objeto conexion
            SqlCommand micomando = new SqlCommand(query, miconexion);
            //ejecutamos la consulta (query SQL)
            //metodo del objeto comando

            int filasafectadas = micomando.ExecuteNonQuery();
            //regresa un valor entero que nos da el numero de filas afectadas en la tabla

            if (filasafectadas > 0)
            {
                MessageBox.Show("Operacion realizada exitosamente", "la base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

            }
        }

        public void actualizargrid(DataGridView dg, String query)
        {
            //conectar a la BD

            this.conectar();

            //creamos la DATASET para actualizar la BD

            System.Data.DataSet midataset = new System.Data.DataSet();

            //creamos un adaptador de datos
            // intermediario entre la BD y la DS

            SqlDataAdapter dataadapter = new SqlDataAdapter(query, miconexion);

            //llenamos en DataSet

            dataadapter.Fill(midataset, "matriUH");

            //asignamos el valor adecuado a las propiedades del datagrid

            dg.DataSource = midataset;
            dg.DataMember = "matriUH";

            //nos deconectamos

            this.desconectar();


        }

    }
}
