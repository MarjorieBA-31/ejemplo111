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
    public partial class MatriculaUH : Form
    {
        private int childFormNumber = 0;

        public MatriculaUH()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            nueva_matricula frm = new nueva_matricula(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }

        private void consultaMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            Consulta_matricula frm = new Consulta_matricula(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            nuevo_alumno frm = new nuevo_alumno(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            Eliminar_Alumna frm = new Eliminar_Alumna(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
           Actualizar_alumno frm = new Actualizar_alumno(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }

        private void elíminarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
           eliminar_carrera frm = new eliminar_carrera(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario



        }

        private void elíminaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            Agregar_carrera frm = new Agregar_carrera(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
            
        }

        private void listaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //objeto que haga una instancia a la clase fmcompras
            Actualizar_carrera frm = new Actualizar_carrera(); //objeto creado
            frm.MdiParent = this;
            frm.Show(); //muestra formulario
        }
    }
}
