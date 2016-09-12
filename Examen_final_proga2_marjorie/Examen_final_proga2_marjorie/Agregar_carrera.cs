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
    public partial class Agregar_carrera : Form
    {
        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public Agregar_carrera()
        {
            InitializeComponent();
        }

        private void Agregar_carrera_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVcarrera, "select * from Carrera");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //este boton tiene 2 funciones, guardar en la BD por primer vez
            //o actualizar en la BD


            if (editar)
            {
                manipulardatos.conectar();
                String query = "update Carrera set nombre = '" + tx_nombre.Text + "', apellido = '" + tx_idcarrera.Text + " where cedula = " + codigo + ";";

                // llamar al metodo
                manipulardatos.ejecutarsql(query);


                //actualizar
                manipulardatos.actualizargrid(this.DGVcarrera, "select * from Carrera;");

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
                String query = "insert into Carrera(idcarrera,nombre)values(" + tx_idcarrera.Text + ",'"  + tx_nombre.Text + "');";


                //ejecutar la query
                manipulardatos.ejecutarsql(query);

                //actualizamos el DGV
                manipulardatos.actualizargrid(this.DGVcarrera, "select * from Carrera");

                //desconectar la BD
                manipulardatos.desconectar();

                //limpiar los textsbox
                limpiartext();

            }


        }
        public void limpiartext()
        {
            tx_idcarrera.Clear();
            tx_nombre.Clear();
           


        }

        private void DGVcarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Materias_Cupos ne = new Materias_Cupos();
            ne.ShowDialog();

        }
    }
    }

