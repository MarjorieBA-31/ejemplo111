using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_sudoku_Marjorie
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        //variables de clase
        private int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //hace se cambie de color del titulo del menu principal
            num = num + 1;
            //si es diferente a cero entra.
            if (num % 2 == 0)
            {
                lb_sudoku1.Visible = true;
                lb_sudoku2.Visible = false;
            }
            //si no es diferente entra a la condicion falsa
            else
            {
                lb_sudoku1.Visible = false;
                lb_sudoku2.Visible = true;
            }
        }

        private void principal_Click(object sender, EventArgs e)
        {
            //llama y muestra el menu principal clientes
             Juego_Sudoku menu = new Juego_Sudoku();
            this.Hide();//oculta el form inicial al presionar ingresar

            menu.ShowDialog();//muestra el form clientes
        }

        private void lb_sudoku1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //cierra el form principal
            Close();
        }
    }
}
