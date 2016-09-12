using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_proga2_marjorie
{
    public partial class Eliminar_Alumna : Form
    {//declarar un objeto para trabajar con la BD
        //lo hacemos aqui para que pueda acceder a todos los metodos

        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        
        public Eliminar_Alumna()
        {
            InitializeComponent();
        }

        private void Eliminar_Alumna_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGValumno, "select * from Alumno");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            //capturar la cedula en el codigo

            codigo = this.DGValumno.CurrentRow.Cells[0].Value.ToString();

            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar

                //conectar a la BD
                manipulardatos.conectar();

                //armar la query borrado
                String query = "delete from Alumno where cedula = '" + codigo + "';";

                //ejecutar la query
                manipulardatos.ejecutarsql(query);

                //actualizar el DGV
                manipulardatos.actualizargrid(this.DGValumno, "select * from Alumno;");

                //desconectar la BD
                manipulardatos.desconectar();

            }

            else //no confirmo el borrado
            {
                return;
            }


        }

    }

}
