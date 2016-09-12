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
    public partial class Actualizar_carrera : Form
    {
        matriculadelaU manipulardatos = new matriculadelaU();
        String codigo;
        Boolean editar; //bandera para saber si es editar o nuevo
        public Actualizar_carrera()
        {
            InitializeComponent();
        }

        private void Actualizar_carrera_Load(object sender, EventArgs e)
        {
            editar = false;
            matriculadelaU objeto = new matriculadelaU();
            objeto.actualizargrid(this.DGVcarrera, "select * from Carrera");
        }

        private void tx_nombreylistadecarrera_KeyUp(object sender, KeyEventArgs e)
        { //a como escribo me va buscando
            manipulardatos.actualizargrid(this.DGVcarrera, "select * from Carrera where nombre like '" + tx_nombreylistadecarrera.Text + "%';");

        }
    }
}
