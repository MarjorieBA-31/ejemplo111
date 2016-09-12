﻿using System;
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
    public partial class nuevo_alumno : Form
    {//declarar un objeto para trabajar con la BD
        //lo hacemos aqui para que pueda acceder a todos los metodos

        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public nuevo_alumno()
        {
            InitializeComponent();
        }

        private void nuevo_alumno_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGValumno, "select * from Alumno");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //este boton tiene 2 funciones, guardar en la BD por primer vez
            //o actualizar en la BD


            if (editar)
            {
                manipulardatos.conectar();
                String query = "update Alumno set nombre = '"+ tx_nombre.Text+ "', apellido = '" + tx_apellido.Text + " where cedula = " + codigo + ";";

                // llamar al metodo
                manipulardatos.ejecutarsql(query);


                //actualizar
                manipulardatos.actualizargrid(this.DGValumno, "select * from Alumno;");

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
                String query = "insert into Alumno(cedula,nombre,apellido)values(" + tx_cedula.Text + ",'" + tx_nombre.Text + "','" + tx_apellido.Text + "');";
               

                //ejecutar la query
                manipulardatos.ejecutarsql(query);

                //actualizamos el DGV
                manipulardatos.actualizargrid(this.DGValumno, "select * from Alumno");

                //desconectar la BD
                manipulardatos.desconectar();

                //limpiar los textsbox
                limpiartext();

            }


        }
        public void limpiartext()
        {
            tx_apellido.Clear();
            tx_cedula.Clear();
            tx_nombre.Clear();
           

        }
    }
}
