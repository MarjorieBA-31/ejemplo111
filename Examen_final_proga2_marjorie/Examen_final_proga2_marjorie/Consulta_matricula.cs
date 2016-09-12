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
    public partial class Consulta_matricula : Form
    {//declarar un objeto para trabajar con la BD
        //lo hacemos aqui para que pueda acceder a todos los metodos

        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public Consulta_matricula()
        {
            InitializeComponent();
        }

        private void Consulta_matricula_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVmatricula, "select * from Matricula");
        }

        private void tx_idAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            //a como escribo me va buscando
            manipulardatos.actualizargrid(this.DGVmatricula, "select * from Matricula where idalumno like '" + tx_idAlumno.Text + "%';");
        }
    }
}
