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
    public partial class Materias_Cupos : Form
    {
        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public Materias_Cupos()
        {
            InitializeComponent();
        }

        private void Materias_Cupos_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVmateria, "select * from Materia");

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //este boton tiene 2 funciones, guardar en la BD por primer vez
            //o actualizar en la BD


            if (editar)
            {
                manipulardatos.conectar();
                String query = "update Materia set codmateria=" + tx_codMateria.Text + ", nombre='" + tx_nombre.Text + "',cupo=" + tx_Cupo.Text + "'where codmateria=" + codigo + ";";

                // llamar al metodo
                manipulardatos.ejecutarsql(query);


                //actualizar
                manipulardatos.actualizargrid(this.DGVmateria, "select * from Materia;");

                //desconestamos
                manipulardatos.desconectar();

                //limpiar texts
                this.limpiartext();

                //cambiar al estado de la bandera
                editar = false;
            }

            //si editar es false (guardar un empleado nuevo)
            else
            {
                //conectamos la BD
                manipulardatos.conectar();

                //armar nuestra variable tipo cadena "query"
                String query = "insert into Materia(codmateria,nombre,cupo)values(" + tx_codMateria.Text + ",'" + tx_nombre.Text + "'," + tx_Cupo.Text + ");";


                //ejecutar la query
                manipulardatos.ejecutarsql(query);

                //actualizamos el DGV
                manipulardatos.actualizargrid(this.DGVmateria, "select * from Materia");

                //desconectar la BD
                manipulardatos.desconectar();

                //limpiar los textsbox
                limpiartext();

            }


        }
        public void limpiartext()
        {
            tx_codMateria.Clear();
            tx_nombre.Clear();
            tx_Cupo.Clear();



        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //capturar la cedula
            codigo = this.DGVmateria.CurrentRow.Cells[0].Value.ToString();
            //preguntar si realmente quiere eliminar
            var resultado = MessageBox.Show("¿Desea realmente eliminar el registro?", "Confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //vamos a eliminar
                //conectar a la base de datos
                manipulardatos.conectar();
                //armar sentencia de borrado
                String query = "delete from Materia where codmateria= '" + codigo + "';";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizar el data
                manipulardatos.actualizargrid(this.DGVmateria, "select*from Materia;");
                //desconectar la base
                manipulardatos.desconectar();
            }
            //no confirmo el borrado
            else
            {
                return;

            }

        }

    }
}


