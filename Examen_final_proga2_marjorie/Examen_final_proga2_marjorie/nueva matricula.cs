using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examen_final_proga2_marjorie
{
    public partial class nueva_matricula : Form
    {//declarar un objeto para trabajar con la BD
        //lo hacemos aqui para que pueda acceder a todos los metodos

        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public nueva_matricula()
        {
            InitializeComponent();
        }

        private void nueva_matricula_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVmatricula, "select * from Matricula");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {//este boton tiene dos funciones, guardar en la base de datos o actualizar en la base de datos
            if (editar)
            {
                manipulardatos.conectar();
                //si es int solo doble comilla
                //la cedula no se toca
                //codigo captura la cedula
                String query = "update Matricula set idalumno=" + tx_idAlumno.Text + ", idcarrera=" + tx_idCarrera.Text + ",idmateria=" + tx_idMateria.Text + ",fechamatricula='" + tx_fecha_matricula.Text + "'where idmatricula=" + codigo + ";";
                //llmar al metdo
                manipulardatos.ejecutarsql(query);
                //actualizar
                manipulardatos.actualizargrid(this.DGVmatricula, "select*from Matricula");
                //desconectar
                manipulardatos.desconectar();
                //limpiar texts
                this.limpiartext();
                //cambiar el estado de la bandera
                editar = false;
                
            }
            else
            {
                //conectar la base de datos
                manipulardatos.conectar();
                //armar variable tipo cadena"query"
                String query = "insert into Matricula(idalumno,idcarrera,idmateria,idmatricula,fechamatricula)values(" + tx_idAlumno.Text + "," + tx_idCarrera.Text + "," + tx_idMateria.Text + "," + tx_idMatricula.Text + ",'" + tx_fecha_matricula.Text + "');";
                //ejecutar la query
                manipulardatos.ejecutarsql(query);
                //actualizamos el data
                manipulardatos.actualizargrid(this.DGVmatricula, "select*from Matricula");
                //desconectar
                manipulardatos.desconectar();
                //limpiar los textbox
                limpiartext();


            }
        }
        public void limpiartext()
        {
            tx_idMatricula.Clear();
            tx_idMateria.Clear();
            tx_idMatricula.Clear();
            tx_idAlumno.Clear();



        }

    }
    }

