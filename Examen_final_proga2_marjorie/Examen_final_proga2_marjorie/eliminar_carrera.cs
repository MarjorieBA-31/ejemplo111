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
    public partial class eliminar_carrera : Form
    {
        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public eliminar_carrera()
        {
            InitializeComponent();
        }

        private void eliminar_carrera_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVcarrera, "select * from Carrera");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            //capturar la cedula en el codigo

            codigo = this.DGVcarrera.CurrentRow.Cells[0].Value.ToString();

            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar

                //conectar a la BD
                manipulardatos.conectar();

                //armar la query borrado
                String query = "delete from Carrera where idcarrera = '" +codigo + "';";

                //ejecutar la query
                manipulardatos.ejecutarsql(query);

                //actualizar el DGV
                manipulardatos.actualizargrid(this.DGVcarrera, "select * from Carrera;");

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

