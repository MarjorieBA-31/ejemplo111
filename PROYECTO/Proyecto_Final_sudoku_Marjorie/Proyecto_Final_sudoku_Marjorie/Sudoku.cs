using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Proyecto_Final_sudoku_Marjorie
{
    public enum Niveles_Juego//para saber los niveles
    {
        SIMPLE,//el enum permite llamar los niveles
        MEDIO,
        DIFICIL,
        MUYDIFICIL
    }

    public partial class Juego_Sudoku : Form
    {

        private int[,] Matriz1facil = {{8,2,9,4,6,1,7,5,3},//Matriz del nivel facil
                                      {5,3,1,8,7,2,9,6,4},
                                      {7,6,4,5,9,3,1,2,8},
                                      {4,7,3,6,2,9,5,8,1},
                                      {1,8,6,7,4,5,2,3,9},
                                      {2,9,5,1,3,8,4,7,6},
                                      {9,1,7,3,5,6,8,4,2},
                                      {6,5,2,9,8,4,3,1,7},
                                      {3,4,8,2,1,7,6,9,5}
                                    };

        int[,] Matriz2medio =                {{3,7,4,2,9,8,1,5,6},//Matriz del nivel medio
                                             {5,2,9,6,7,1,8,3,4},
                                             {8,1,6,3,5,4,2,7,9},
                                             {7,6,5,8,3,2,9,4,1},
                                             {1,9,8,7,4,6,3,2,5},
                                             {2,4,3,5,1,9,7,6,8},
                                             {4,8,7,1,6,3,5,9,2},
                                             {9,5,2,4,8,7,6,1,3},
                                             {6,3,1,9,2,5,4,8,7}
                                    };
        int[,] Matriz3dificil =             {{5,8,2,4,7,9,6,1,3},//Matriz del nivel medio
                                             {4,7,3,1,6,8,9,5,2},
                                             {9,1,6,2,5,3,4,7,8},
                                             {2,4,1,6,3,7,5,8,9},
                                             {8,3,9,5,1,4,2,6,7},
                                             {7,6,5,8,9,2,3,4,1},
                                             {6,9,7,3,8,5,1,2,4},
                                             {1,2,8,9,4,6,7,3,5},
                                             {3,5,4,7,2,1,8,9,6}
                                    };
        int[,] Matriz4muydificil =          {{2,7,3,4,9,1,5,6,8},//Matriz del nivel medio
                                             {6,4,9,8,7,5,1,2,3},
                                             {1,5,8,2,6,3,4,7,9},
                                             {7,8,6,1,2,4,9,3,5},
                                             {5,9,1,7,3,8,2,4,6},
                                             {4,3,2,6,5,9,7,8,1},
                                             {3,1,7,5,8,2,6,9,4},
                                             {9,6,4,3,1,7,8,5,2},
                                             {8,2,5,9,4,6,3,1,7}
                                    };



        int i_Sec, i_Min, i_Hour, milesegundos = 0;//variables de minutos

        //Hace invisible los cuadros del primer nivel
        public Juego_Sudoku()
        {//Inicializa los componentes del datagrieview
            InitializeComponent();
            Datagriview();
            Datagriview2();
            Datagriview3();
            Datagriview4();
            Tablas(Matriz1facil, 0);
            Tablas2(Matriz2medio, 0);
            Tablas3(Matriz3dificil, 0);
            Tablas4(Matriz4muydificil, 0);
            //botones que seran visibles
            check.Visible = false;
            bt_ayuda.Visible = false;
            Reiniciar.Visible = false;
            Asperdido.Visible = false;
            paratercernivel.Visible = false;
            paracuartonivel.Visible = false;
            parasegundonivel.Visible = false;
            paranivel1.Visible = false;
            Nivel3.Visible = false;
            Nivel2.Visible = false;
            Nivel4.Visible = false;
            datagridview_juego_cuadro.Visible = false; //no deja ver nada de esto en el principio 
            tx_facil_nivel.Visible = false;
            tx_medio_nivel.Visible = false;
            tx_dificil_nivel.Visible = false;
            tx_muydificil_nivel.Visible = false;
            tx_respuesta_nivel1.Visible = false;
            tx_respuesta_nivel2.Visible = false;
            tx_respuesta_nivel3.Visible = false;
            tx_respuesta_nivel4.Visible = false;
            lb_difilcultad.Visible = false;
            lb_mensaje.Text = "";
        }

        //Metodo que valida los campos que estan incorrectos
        private void check_Click(object sender, EventArgs e)
        { //valida los campos que no son correctos y los pone otro color
          //--------------------------------1Matriz---------------------------------

            if (


              datagridview_juego_cuadro.Rows[2].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[2].Cells[0].Style.BackColor = Color.Crimson;

            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[3].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[0].Style.BackColor = Color.Crimson;
            }
            else
            {

            }
            if (
              datagridview_juego_cuadro.Rows[4].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[4].Cells[0].Style.BackColor = Color.Crimson;
            }
            else
            {


            }
            if (datagridview_juego_cuadro.Rows[5].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[5].Cells[0].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[6].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[6].Cells[0].Style.BackColor = Color.Crimson;
            }
            else { }


            if (datagridview_juego_cuadro.Rows[7].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[7].Cells[0].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[8].Cells[0].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[8].Cells[0].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[2].Cells[1].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[2].Cells[1].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[3].Cells[1].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[1].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[5].Cells[1].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[5].Cells[1].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[6].Cells[1].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[6].Cells[1].Style.BackColor = Color.Crimson;
            }
            else
            {

            }



            if (datagridview_juego_cuadro.Rows[8].Cells[1].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[8].Cells[1].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[2].Cells[2].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[2].Cells[2].Style.BackColor = Color.Crimson;
            }
            else
            {

            }
            if (datagridview_juego_cuadro.Rows[3].Cells[2].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[2].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[4].Cells[2].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[4].Cells[2].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[6].Cells[2].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[6].Cells[2].Style.BackColor = Color.Crimson;
            }
            else
            {

            }



            if (datagridview_juego_cuadro.Rows[4].Cells[3].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[4].Cells[3].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[0].Cells[4].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[0].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {
            }

            if (datagridview_juego_cuadro.Rows[1].Cells[4].Style.BackColor != Color.Fuchsia)

            {
                datagridview_juego_cuadro.Rows[1].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[3].Cells[4].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[4].Cells[4].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[4].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {

            }
            if (datagridview_juego_cuadro.Rows[5].Cells[4].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[5].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[8].Cells[4].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[8].Cells[4].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[0].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[0].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }
            if (datagridview_juego_cuadro.Rows[1].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[1].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[3].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[6].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[6].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[7].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[7].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[8].Cells[5].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[8].Cells[5].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[6].Cells[7].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[6].Cells[7].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[7].Cells[7].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[7].Cells[7].Style.BackColor = Color.Crimson;
            }
            else
            {

            }


            if (datagridview_juego_cuadro.Rows[8].Cells[7].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[8].Cells[7].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[3].Cells[8].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[3].Cells[8].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[4].Cells[8].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[4].Cells[8].Style.BackColor = Color.Crimson;
            }
            else
            {

            }

            if (datagridview_juego_cuadro.Rows[5].Cells[8].Style.BackColor != Color.Fuchsia)
            {
                datagridview_juego_cuadro.Rows[5].Cells[8].Style.BackColor = Color.Crimson;
            }
            else
            {

            }
            //------------------------------------------------2MATRIZ--------------------------------------------

            if (Nivel2.Rows[1].Cells[0].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[0].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[2].Cells[0].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[2].Cells[0].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[3].Cells[0].Style.BackColor != Color.LightSkyBlue)
            { Nivel2.Rows[3].Cells[0].Style.BackColor = Color.LightGreen; }
            else
            {

            }

            if (Nivel2.Rows[4].Cells[0].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[0].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }
            if (Nivel2.Rows[5].Cells[0].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[5].Cells[0].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[6].Cells[0].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[0].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[0].Cells[1].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[0].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }
            if (Nivel2.Rows[1].Cells[1].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[2].Cells[1].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[2].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[3].Cells[1].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[3].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[6].Cells[1].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[1].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[0].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[0].Cells[2].Style.BackColor = Color.LightGreen;

            }
            else
            {

            }



            if (Nivel2.Rows[2].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[2].Cells[2].Style.BackColor = Color.LightGreen;

            }
            else
            {


            }

            if (Nivel2.Rows[3].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[3].Cells[2].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[4].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[2].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }

            if (Nivel2.Rows[6].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[2].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[7].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[7].Cells[2].Style.BackColor = Color.LightGreen;
            }
            else
            {
            }



            if (Nivel2.Rows[8].Cells[2].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[2].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }
            if (Nivel2.Rows[1].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[3].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[3].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[3].Cells[3].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[4].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[3].Style.BackColor = Color.LightGreen;

            }
            else
            {

            }

            if (Nivel2.Rows[5].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[5].Cells[3].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }
            if (Nivel2.Rows[6].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[3].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[7].Cells[3].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[7].Cells[3].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[1].Cells[4].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[4].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[4].Cells[4].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[4].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[6].Cells[4].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[4].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[7].Cells[4].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[7].Cells[4].Style.BackColor = Color.LightGreen;

            }
            else
            {

            }

            if (Nivel2.Rows[8].Cells[4].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[4].Style.BackColor = Color.LightGreen;

            }
            else
            {


            }

            if (Nivel2.Rows[1].Cells[5].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[3].Cells[5].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[3].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }

            if (Nivel2.Rows[4].Cells[5].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }
            if (Nivel2.Rows[7].Cells[5].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[7].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }

            if (Nivel2.Rows[8].Cells[5].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[5].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[0].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[0].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[2].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[2].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[5].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[5].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[6].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[7].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[7].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }

            if (Nivel2.Rows[8].Cells[6].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[6].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[0].Cells[7].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[0].Cells[7].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[3].Cells[7].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[3].Cells[7].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }
            if (Nivel2.Rows[4].Cells[7].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[4].Cells[7].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[5].Cells[7].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[5].Cells[7].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[8].Cells[7].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[7].Style.BackColor = Color.LightGreen;

            }
            else
            {


            }
            if (Nivel2.Rows[0].Cells[8].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[0].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }

            if (Nivel2.Rows[1].Cells[8].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[1].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }

            if (Nivel2.Rows[5].Cells[8].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[5].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {

            }


            if (Nivel2.Rows[6].Cells[8].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[6].Cells[8].Style.BackColor = Color.LightGreen;
            }
            else
            {


            }
            if (Nivel2.Rows[8].Cells[8].Style.BackColor != Color.LightSkyBlue)
            {
                Nivel2.Rows[8].Cells[8].Style.BackColor = Color.LightGreen;

            }
            else
            {


            }
            //---------------------------------------------tercerNivel--------------------------------


            if (Nivel3.Rows[1].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[0].Style.BackColor = Color.Olive;
            }
            else
            {

            }

            if (Nivel3.Rows[2].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[3].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[4].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[5].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[6].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[6].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[7].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[0].Style.BackColor = Color.Olive;
            }
            else { }
            if (Nivel3.Rows[8].Cells[0].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[8].Cells[0].Style.BackColor = Color.Olive;

            }
            else { }


            if (Nivel3.Rows[0].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[1].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[1].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[1].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[2].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[1].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[4].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[1].Style.BackColor = Color.Olive;
            }
            else { }



            if (Nivel3.Rows[5].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[1].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[7].Cells[1].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[1].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[1].Cells[2].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[2].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[2].Cells[2].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[2].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[4].Cells[2].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[2].Style.BackColor = Color.Olive;
            }
            else { }



            if (Nivel3.Rows[7].Cells[2].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[2].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[0].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[3].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[1].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[3].Style.BackColor = Color.Olive;
            }
            else
            {

            }
            if (Nivel3.Rows[2].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[3].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[3].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[3].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[5].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[3].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[6].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[6].Cells[3].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[7].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[3].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[8].Cells[3].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[8].Cells[3].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[0].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[2].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[3].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[4].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[5].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[7].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[4].Style.BackColor = Color.Olive;

            }
            else { }
            if (Nivel3.Rows[8].Cells[4].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[8].Cells[4].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[0].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[5].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[1].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[5].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[2].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[5].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[4].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[5].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[7].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[7].Cells[5].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[8].Cells[5].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[8].Cells[5].Style.BackColor = Color.Olive;

            }
            else { }


            if (Nivel3.Rows[0].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[2].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[3].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[4].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[5].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[6].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[6].Cells[6].Style.BackColor = Color.Olive;
            }
            else
            {

            }

            if (Nivel3.Rows[7].Cells[6].Style.BackColor != Color.SlateGray)
            { Nivel3.Rows[7].Cells[6].Style.BackColor = Color.Olive; }
            else { }

            if (Nivel3.Rows[8].Cells[6].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[8].Cells[6].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[0].Cells[7].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[7].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[1].Cells[7].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[7].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[2].Cells[7].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[7].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[3].Cells[7].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[7].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[5].Cells[7].Style.BackColor != Color.SlateGray)
            {
                ;
                Nivel3.Rows[5].Cells[7].Style.BackColor = Color.Olive;

            }
            else { }

            if (Nivel3.Rows[6].Cells[7].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[6].Cells[7].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[0].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[0].Cells[8].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[1].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[1].Cells[8].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[2].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[2].Cells[8].Style.BackColor = Color.Olive;

            }
            else { }



            if (Nivel3.Rows[3].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[3].Cells[8].Style.BackColor = Color.Olive;
            }
            else { }


            if (Nivel3.Rows[4].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[4].Cells[8].Style.BackColor = Color.Olive;
            }
            else { }

            if (Nivel3.Rows[5].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[5].Cells[8].Style.BackColor = Color.Olive;

            }
            else { }


            if (Nivel3.Rows[6].Cells[8].Style.BackColor != Color.SlateGray)
            {
                Nivel3.Rows[6].Cells[8].Style.BackColor = Color.Olive;
            }
            else { }
            //----------------------------------------4MATRIZ--------------------------------------------------------------
            if (Nivel4.Rows[1].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[0].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[2].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[0].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[3].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[0].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[4].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[0].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[5].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[0].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[6].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[0].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[7].Cells[0].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[0].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[0].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }
            if (Nivel4.Rows[1].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[1].Style.BackColor = Color.Gainsboro;

            }
            else { }


            if (Nivel4.Rows[2].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }



            if (Nivel4.Rows[6].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[4].Cells[1].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[1].Style.BackColor = Color.Gainsboro;
            }
            else { }



            if (Nivel4.Rows[0].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[2].Style.BackColor = Color.Gainsboro;
            }
            else { }



            if (Nivel4.Rows[2].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[2].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[2].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[4].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[2].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[5].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[2].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[6].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[2].Style.BackColor = Color.Gainsboro;

            }

            if (Nivel4.Rows[7].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[2].Style.BackColor = Color.Gainsboro;
            }



            if (Nivel4.Rows[8].Cells[2].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[2].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[1].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[3].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[2].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[3].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[3].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[3].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[4].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[3].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[5].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[3].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[6].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[3].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[7].Cells[3].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[3].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[0].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[4].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[1].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[4].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[4].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[4].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[4].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[6].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[4].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[7].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[4].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[4].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[4].Style.BackColor = Color.Gainsboro;
            }
            else
            {

            }

            if (Nivel4.Rows[0].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[5].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[1].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[5].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[5].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[4].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[5].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[7].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[5].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[5].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[5].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[0].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[2].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[5].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[6].Style.BackColor = Color.Gainsboro;

            }
            else { }


            if (Nivel4.Rows[6].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[7].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[6].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[6].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[0].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[7].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[1].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[7].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[3].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[7].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[4].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[4].Cells[7].Style.BackColor = Color.Gainsboro;


            }


            if (Nivel4.Rows[5].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[7].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[6].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[7].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[7].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[7].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[0].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[0].Cells[8].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[1].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[1].Cells[8].Style.BackColor = Color.Gainsboro;

            }
            else { }

            if (Nivel4.Rows[2].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[2].Cells[8].Style.BackColor = Color.Gainsboro;
            }

            if (Nivel4.Rows[3].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[3].Cells[8].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[5].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[5].Cells[8].Style.BackColor = Color.Gainsboro;
            }
            else { }


            if (Nivel4.Rows[6].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[6].Cells[8].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[7].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[7].Cells[8].Style.BackColor = Color.Gainsboro;
            }
            else { }

            if (Nivel4.Rows[8].Cells[8].Style.BackColor != Color.Navy)
            {
                Nivel4.Rows[8].Cells[8].Style.BackColor = Color.Gainsboro;
            }

        }



        //---------------------------------------------------------------------Pimera matriz-------------------------------------------------------------------
        //filas y columnas del sudoku
        private void Datagriview()
        {
            datagridview_juego_cuadro.ColumnCount = 9;//define el numero de columnas
            DataGridViewColumn columna1 = datagridview_juego_cuadro.Columns[0];

            columna1.Width = 45;//define el largo de la columnas
            DataGridViewColumn columna2 = datagridview_juego_cuadro.Columns[1];
            columna2.Width = 45;
            DataGridViewColumn columna3 = datagridview_juego_cuadro.Columns[2];
            columna3.Width = 45;
            DataGridViewColumn columna4 = datagridview_juego_cuadro.Columns[3];
            columna4.Width = 45;
            DataGridViewColumn columna5 = datagridview_juego_cuadro.Columns[4];
            columna5.Width = 45;
            DataGridViewColumn columna6 = datagridview_juego_cuadro.Columns[5];
            columna6.Width = 45;
            DataGridViewColumn columna7 = datagridview_juego_cuadro.Columns[6];
            columna7.Width = 45;
            DataGridViewColumn columna8 = datagridview_juego_cuadro.Columns[7];
            columna8.Width = 45;
            DataGridViewColumn columna9 = datagridview_juego_cuadro.Columns[8];
            columna9.Width = 45;
            datagridview_juego_cuadro.Size = new Size(408, 408);//define el tamaño del data grid

            datagridview_juego_cuadro.GridColor = Color.Black;//Define el color de los bordes del los cuadritos del datagridview
            datagridview_juego_cuadro.BackgroundColor = Color.Black;//color del contorno del cuadro
          
        }
        //nuevo juego
        private void tx_nuevo_juego_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //hace invisibles los cuadros de los pickure para los demas niveles
            paracuartonivel.Visible = false;
            paratercernivel.Visible = false;
            parasegundonivel.Visible = false;
            paranivel1.Visible = false;
            Asperdido.Visible = false;
            //limpia los label de la hora
            milesegundos = 0;
            i_Sec = 0;
            i_Min = 0;
            i_Hour = 0;//variables de minutos
          //variables me convierten a cero el cronometro para que vuelva a empezar
            lbl_Txt_Hours.Text = 0.ToString();
            lbl_Txt_Mins.Text = 0.ToString();
            lbl_Txt_Secs.Text = 0.ToString();


            //hace visibles estos botones

            lb_difilcultad.Visible = true;
            tx_facil_nivel.Visible = true;//muestra estos potones despues de apretar nuevo
            tx_medio_nivel.Visible = true;
            tx_dificil_nivel.Visible = true;
            tx_muydificil_nivel.Visible = true;
            datagridview_juego_cuadro.Visible = false;//esconde el data grid despues de darle nuevo
           
            bt_ayuda.Visible = false;
            Reiniciar.Visible = false;
            check.Visible = false;
            tx_respuesta_nivel1.Visible = false;
            tx_respuesta_nivel2.Visible = false;
            tx_respuesta_nivel3.Visible = false;
            tx_respuesta_nivel4.Visible = false;
            Nivel2.Visible = false;
            Nivel3.Visible = false;
            Nivel4.Visible = false;
            lb_mensaje.Text = "";
        }

        private void tx_salir_Click(object sender, EventArgs e)
        {  //se sale dela aplicacion
            Application.ExitThread();//cierra totalmente el programa
           
        }

        //nivel de dificultad del juego
        private void Nivel_dificultad_juego_seleccionado(object sender, EventArgs e)
        {
          

            if (sender == tx_facil_nivel)//primer nivel
            {
                nuevojuego(0);
             
                
                lb_mensaje.Visible = true;
                
            }
            else if (sender == tx_medio_nivel)//segundo nivel
            {
                nuevojuego(1);
            }
            else if (sender == tx_dificil_nivel)//tercero nivel
            {
                nuevojuego(2);
            }
            else
            {
                nuevojuego(3);//cuarto nivel
            }
            lb_difilcultad_Click(sender, e);//llama al metodo de nivel de dificultad
        }

        private void tx_respuesta_nivel1_Click(object sender, EventArgs e)//respuesta visibles al data grid
        {
          //detiene el tiempo
            timer1.Stop();
          //Hace visible o inbisibles estos botones para el nievel1
            tx_respuesta_nivel1.Visible = true;
            tx_respuesta_nivel2.Visible = false;
            tx_respuesta_nivel3.Visible = false;
            tx_respuesta_nivel4.Visible = false;
            Nivel2.Visible = false;
            Asperdido.Visible = true;
            tx_nuevo_juego.Visible = true;
            lb_mensaje.Visible = false;
            Respuestas_Visibles();
        }

        private void hover(object sender, EventArgs e)//cambio de color
        {
            var cambiocolorcursor = (Button)sender;//decaro la variable
            cambiocolorcursor.BackColor = Color.Aqua;//cambia de color al tocarlo el boton con el mause
        }

        private void leaver(object sender, EventArgs e)//cambia de color
        {
            var cambiacolorcursor = (Button)sender;
            cambiacolorcursor.BackColor = Color.SkyBlue;//cambia de color al tocar el boton  con el mause
        }


        //visibles botones
        private void lb_difilcultad_Click(object sender, EventArgs e)
        {//hace invisibles estos botones
            tx_facil_nivel.Visible = false;
            tx_medio_nivel.Visible = false;
            tx_dificil_nivel.Visible = false;
            tx_muydificil_nivel.Visible = false;

            lb_difilcultad.Visible = false;//hace invisible el boton

           // lb_mensaje.Visible = false;//lo muestra visible solo ya cuando tiene las respuestas correcta


        }


        //muestra las tablas del tadagridview
        private void Tablas(int[,] soluciones, int dificultades)
        {
            var numfilas = 9;//numero de filas
            var numcolumnas = 9;//numeros de columnas

            for (int pocisionfila = 0; pocisionfila < numfilas; ++pocisionfila)//recorre las posiciones de las filas
            {
                var filas = new DataGridViewRow();//declaro la fila para el datagrid
                filas.Height = 45;//ancho de las columnas
                for (int pocisioncolumnas = 0; pocisioncolumnas < numcolumnas; ++pocisioncolumnas)//for que correcore las columas
                {


                    filas.Cells.Add(new DataGridViewTextBoxCell()//agrega las columnas al data grid
                    {
                        Value = soluciones[pocisionfila, pocisioncolumnas]//evalua las posiciones de las filas y columnas
                    });


                }

                datagridview_juego_cuadro.Rows.Add(filas);//Agrega las filas

            }
        }

        //nivel de dificultad
        private void nuevojuego(int posicion)//obtiene como parametro la posicion
        {
            i_Sec = i_Min = i_Hour = 0;
            timer1.Stop();
            Niveles_Juego[] levels = { Niveles_Juego.SIMPLE, Niveles_Juego.MEDIO, Niveles_Juego.DIFICIL, Niveles_Juego.MUYDIFICIL };//llama del enum los niveles
            if (posicion == 0)
            {
                Respuestas_Invisibles(0);//primer nivel
               
            }
            else if (posicion == 1)//segundo nivel
            {
                Respuestas_Invisibles1(1);
            }
            else if (posicion == 2)
            {
                Respuestas_Invisibles3(2);//Tercer nivel
            }
            else if (posicion == 3)
            {
                Respuestas_Invisibles5(3);//Cuarto Nivel
            }

        }
        //crea los espacios vacios en data grid y es donde oculta las respuestas

        private void Respuestas_Invisibles(int level)
        {
          
            Respuestas_Visibles();//llama a los que estan visibles

            //entra al primer nivel esta condicion
            if (level == 0)
            {//hace visibles estos botones
                check.Visible = true;
                bt_ayuda.Visible = true;
                Reiniciar.Visible = true;
                paranivel1.Visible = true;
                timer1.Start();
                datagridview_juego_cuadro.Visible = true;//esconde el data grid despues de darle nuevo
                tx_respuesta_nivel1.Visible = true;//visible boton respuesta1
                Respuestas_Visibles();//llama a los que estan visibles
                tx_facil_nivel.Visible = false;
                check.Visible = true;
                datagridview_juego_cuadro.Rows[2].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[2].Cells[0].Style.BackColor = Color.Magenta;//da color al cuadro vacio
                datagridview_juego_cuadro.Rows[3].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[0].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[4].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[4].Cells[0].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[5].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[5].Cells[0].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[6].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[6].Cells[0].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[7].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[7].Cells[0].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[8].Cells[0].Value = null;
                datagridview_juego_cuadro.Rows[8].Cells[0].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[2].Cells[1].Value = null;
                datagridview_juego_cuadro.Rows[2].Cells[1].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[3].Cells[1].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[1].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[5].Cells[1].Value = null;
                datagridview_juego_cuadro.Rows[5].Cells[1].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[6].Cells[1].Value = null;
                datagridview_juego_cuadro.Rows[6].Cells[1].Style.BackColor = Color.Magenta;


                datagridview_juego_cuadro.Rows[8].Cells[1].Value = null;
                datagridview_juego_cuadro.Rows[8].Cells[1].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[2].Cells[2].Value = null;
                datagridview_juego_cuadro.Rows[2].Cells[2].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[3].Cells[2].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[2].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[4].Cells[2].Value = null;
                datagridview_juego_cuadro.Rows[4].Cells[2].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[6].Cells[2].Value = null;
                datagridview_juego_cuadro.Rows[6].Cells[2].Style.BackColor = Color.Magenta;


                datagridview_juego_cuadro.Rows[4].Cells[3].Value = null;
                datagridview_juego_cuadro.Rows[4].Cells[3].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[0].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[0].Cells[4].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[1].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[1].Cells[4].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[3].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[4].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[4].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[4].Cells[4].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[5].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[5].Cells[4].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[8].Cells[4].Value = null;
                datagridview_juego_cuadro.Rows[8].Cells[4].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[0].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[0].Cells[5].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[1].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[1].Cells[5].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[3].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[5].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[6].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[6].Cells[5].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[7].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[7].Cells[5].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[8].Cells[5].Value = null;
                datagridview_juego_cuadro.Rows[8].Cells[5].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[6].Cells[7].Value = null;
                datagridview_juego_cuadro.Rows[6].Cells[7].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[7].Cells[7].Value = null;
                datagridview_juego_cuadro.Rows[7].Cells[7].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[8].Cells[7].Value = null;
                datagridview_juego_cuadro.Rows[8].Cells[7].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[3].Cells[8].Value = null;
                datagridview_juego_cuadro.Rows[3].Cells[8].Style.BackColor = Color.Magenta;
                datagridview_juego_cuadro.Rows[4].Cells[8].Value = null;
                datagridview_juego_cuadro.Rows[4].Cells[8].Style.BackColor = Color.Magenta;

                datagridview_juego_cuadro.Rows[5].Cells[8].Value = null;
                datagridview_juego_cuadro.Rows[5].Cells[8].Style.BackColor = Color.Magenta;

               
            }

         

        }



        //Muestras las respuestas visibles al usuario
        private void Respuestas_Visibles()
        {//for que rrecorre las columnas y filas
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    datagridview_juego_cuadro.Rows[i].Cells[j].Value = Matriz1facil[i, j];//los llena con la respuesta correcta los cuadros,se pueden odservar
                    datagridview_juego_cuadro.Rows[i].Cells[j].Style.BackColor = Color.Fuchsia;//da color a los cuadros cuando me oloco ensima
                   

                }
            }
        }
        //Permite que el usuario pueda ingresar numeros al data grid
        private void datagridview_juego_cuadro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datagridview_juego_cuadro.Rows[e.RowIndex].ReadOnly = true;//si es verdad entonces los cuadritos se pueden escribir

            if (datagridview_juego_cuadro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//si es nulo se puede escribir
            {
                datagridview_juego_cuadro.Rows[e.RowIndex].ReadOnly = false;
                lb_mensaje.Visible = true;
               

            }
          
            
        }
        //valida los campos del data griview
        private void datagridview_juego_cuadro_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))//permite validad los numeros para irse por la forma false
            { }
            else
            {
                string posiblerespuesta = e.FormattedValue.ToString();//posible respuestas
                int val = Convert.ToInt32(posiblerespuesta);//convierto a strin

                if (val == Matriz1facil[e.RowIndex, e.ColumnIndex])
                {
                    datagridview_juego_cuadro.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Fuchsia;//me canbia el color de los cuadros cuando los toco 
                }
                else
                {
                    datagridview_juego_cuadro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;//si son nulos no les da el color
                }
               
               
                if (//este if me permite validar los numeros por separados para decir si gano o perdio
                  datagridview_juego_cuadro.Rows[2].Cells[0].Style.BackColor == Color.Fuchsia &&//los valida verdad si es fuchsia todos si se cumple gana si no sigue asta ganar

                datagridview_juego_cuadro.Rows[3].Cells[0].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[4].Cells[0].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[5].Cells[0].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[6].Cells[0].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[7].Cells[0].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[8].Cells[0].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[2].Cells[1].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[3].Cells[1].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[5].Cells[1].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[6].Cells[1].Style.BackColor == Color.Fuchsia &&



                datagridview_juego_cuadro.Rows[8].Cells[1].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[2].Cells[2].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[3].Cells[2].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[4].Cells[2].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[6].Cells[2].Style.BackColor == Color.Fuchsia &&



                datagridview_juego_cuadro.Rows[4].Cells[3].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[0].Cells[4].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[1].Cells[4].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[3].Cells[4].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[4].Cells[4].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[5].Cells[4].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[8].Cells[4].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[0].Cells[5].Style.BackColor == Color.Fuchsia &&
                datagridview_juego_cuadro.Rows[1].Cells[5].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[3].Cells[5].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[6].Cells[5].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[7].Cells[5].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[8].Cells[5].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[6].Cells[7].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[7].Cells[7].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[8].Cells[7].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[3].Cells[8].Style.BackColor == Color.Fuchsia &&

                datagridview_juego_cuadro.Rows[4].Cells[8].Style.BackColor == Color.Fuchsia &&


                datagridview_juego_cuadro.Rows[5].Cells[8].Style.BackColor == Color.Fuchsia
              ) 


                {
                    
                    lb_mensaje.Text = "❤‿❤ GANASTES ❤‿❤";//mensaje cuando se gana el juego si se cumple que todas estan del mismo color
                    
                }

                else
                {
                    lb_mensaje.Text = "SIGA JUGANDO!";//mensaje de que siga jugando por que no se a ganada 
                  
                }
            }
        }

            

        private void Juego_Sudoku_Load(object sender, EventArgs e)//formulario principal
        {

        }

        private void datagridview_juego_cuadro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Metodo que me muestra el cronometro en perfecto funcionamiento
        private void timer1_Tick(object sender, EventArgs e)
        {//convierta a texto las variables
            lbl_Txt_Hours.Text = i_Hour.ToString();
            lbl_Txt_Mins.Text = i_Min.ToString();
            lbl_Txt_Secs.Text = i_Sec.ToString();
           //si mele segundo es -1 entonces se suma un minuto

            if (milesegundos > -1)
            {
                i_Sec++;
                milesegundos = 0;
            }
            else
            {//sino miles segundo se aumneta
                milesegundos++;

            }
            if (i_Sec > 60)//convierte un minutos al tener 60 segundos
            {
                i_Min++;
                i_Sec = 0;
            }
            if (i_Min > 60)//convierte una hora al tener 60 minutos
            {
                i_Hour++;
                i_Min = 0;
            }

        }

        //......................................Metodos de segunda Matriz del Nivel Medio...................................................

        //filas y columnas del sudoku
        private void Datagriview2()
        {
            Nivel2.ColumnCount = 9;//define el numero de columnas
            DataGridViewColumn columna1 = Nivel2.Columns[0];

            columna1.Width = 45;//define el largo de la columnas
            DataGridViewColumn columna2 = Nivel2.Columns[1];
            columna2.Width = 45;
            DataGridViewColumn columna3 = Nivel2.Columns[2];
            columna3.Width = 45;
            DataGridViewColumn columna4 = Nivel2.Columns[3];
            columna4.Width = 45;
            DataGridViewColumn columna5 = Nivel2.Columns[4];
            columna5.Width = 45;
            DataGridViewColumn columna6 = Nivel2.Columns[5];
            columna6.Width = 45;
            DataGridViewColumn columna7 = Nivel2.Columns[6];
            columna7.Width = 45;
            DataGridViewColumn columna8 = Nivel2.Columns[7];
            columna8.Width = 45;
            DataGridViewColumn columna9 = Nivel2.Columns[8];
            columna9.Width = 45;
            Nivel2.Size = new Size(408, 408);//define el tamaño del data grid

            Nivel2.GridColor = Color.Red;//Define el color de los bordes del los cuadritos del datagridview
            Nivel2.BackgroundColor = Color.Red;//color del contorno del cuadro
        }
        //muestra las tablas del tadagridview
        private void Tablas2(int[,] soluciones, int dificultades)
        {
            var numfilas = 9;//numero de filas
            var numcolumnas = 9;//numeros de columnas

            for (int pocisionfila = 0; pocisionfila < numfilas; ++pocisionfila)//recorre las posiciones de las filas
            {
                var filas = new DataGridViewRow();//declaro la fila para el datagrid
                filas.Height = 45;//ancho de las columnas
                for (int pocisioncolumnas = 0; pocisioncolumnas < numcolumnas; ++pocisioncolumnas)//for que correcore las columas
                {


                    filas.Cells.Add(new DataGridViewTextBoxCell()//agrega las columnas al data grid
                    {
                        Value = soluciones[pocisionfila, pocisioncolumnas]//evalua las posiciones de las filas y columnas
                    });


                }

                Nivel2.Rows.Add(filas);//Agrega las filas

            }



        }
        //Metodo que me permite escribir en los espacios en blancos
        private void Nivel2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nivel2.Rows[e.RowIndex].ReadOnly = true;
            if (Nivel2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//permite que se escriba un numero si el espacio esta nulo
            {
                Nivel2.Rows[e.RowIndex].ReadOnly = false;
                lb_mensaje.Visible = true;

            }
          
        }

        private void Nivel2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))//Valida los espacios correctos de cuadro
            {

            }
            else
            {

                string posiblerespuesta = e.FormattedValue.ToString();//posible respuestas
                int val = Convert.ToInt32(posiblerespuesta);//convierto a strin

                if (val == Matriz2medio[e.RowIndex, e.ColumnIndex])
                {
                    //si el numero es correcto lo pone de color Linhtskyblue
                    Nivel2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightSkyBlue;


                }
                else
                    //si el numero es incorrecta lo deja en nulo
                    Nivel2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }
           
            if (//este if permite validr que todas los cuadritos sean de un solo color
              Nivel2.Rows[1].Cells[0].Style.BackColor == Color.LightSkyBlue && 

            Nivel2.Rows[2].Cells[0].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[3].Cells[0].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[4].Cells[0].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[5].Cells[0].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[6].Cells[0].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[0].Cells[1].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[1].Cells[1].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[2].Cells[1].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[3].Cells[1].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[6].Cells[1].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[0].Cells[2].Style.BackColor == Color.LightSkyBlue &&



            Nivel2.Rows[2].Cells[2].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[3].Cells[2].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[4].Cells[2].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[6].Cells[2].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[7].Cells[2].Style.BackColor == Color.LightSkyBlue &&



            Nivel2.Rows[8].Cells[2].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[3].Cells[3].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[4].Cells[3].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[5].Cells[3].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[6].Cells[3].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[7].Cells[3].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[1].Cells[4].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[4].Cells[4].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[6].Cells[4].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[7].Cells[4].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[8].Cells[4].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[1].Cells[5].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[3].Cells[5].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[4].Cells[5].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[7].Cells[5].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[8].Cells[5].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[0].Cells[6].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[2].Cells[6].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[5].Cells[6].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[6].Cells[6].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[7].Cells[6].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[8].Cells[6].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[0].Cells[7].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[3].Cells[7].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[4].Cells[7].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[5].Cells[7].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[8].Cells[7].Style.BackColor == Color.LightSkyBlue &&
            Nivel2.Rows[0].Cells[8].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[1].Cells[8].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[5].Cells[8].Style.BackColor == Color.LightSkyBlue &&


            Nivel2.Rows[6].Cells[8].Style.BackColor == Color.LightSkyBlue &&

            Nivel2.Rows[8].Cells[8].Style.BackColor == Color.LightSkyBlue
                )
          
        
            {
               
                lb_mensaje.Text = "❤‿❤ GANASTES ❤‿❤ ";//mensaje cuando se gana el juego
              
            }

            else
            {
                lb_mensaje.Text = "SIGA JUGANDO!";//mensaje que siga jugando si tiene cuadros incorrectos
             
            }





        }

        //nuevo juego
        //respuestas de la segunda matriz del nivel medio los botones que hace visible
        private void tx_respuesta_nivel2_Click(object sender, EventArgs e)
        {//hace invisibles las respuesta
            i_Sec = i_Min = i_Hour = 0;
            timer1.Stop();
            Asperdido.Visible = true;
            tx_respuesta_nivel1.Visible = false;//esconde
            tx_respuesta_nivel2.Visible = true;//deja solo este al pedir ayuda
            tx_respuesta_nivel3.Visible = false;
            tx_respuesta_nivel4.Visible = false;
            tx_nuevo_juego.Visible = true;
            lb_mensaje.Visible = false;
            Respuestas_Visibles4();
        }

        //valida las respuestas
        private void Respuestas_Visibles4()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Nivel2.Rows[i].Cells[j].Value = Matriz2medio[i, j];//los llena con la respuesta correcta los cuadros
                    Nivel2.Rows[i].Cells[j].Style.BackColor = Color.LightSkyBlue;//si son correctas les da este color
                }
            }
        }

        //crea los espacios vacios en data grid y es donde oculta las respuestas

        private void Respuestas_Invisibles1(int level)
        {
            Respuestas_Visibles4();//llama a los que estan visibles


           
            //entra al nivel medio
            //les da color a los espacios nulos
            if (level == 1)
            {
                timer1.Start();
                Nivel2.Visible = true;
                parasegundonivel.Visible = true;
                bt_ayuda.Visible = true;
                Reiniciar.Visible = true;
                check.Visible = true;
               
                tx_respuesta_nivel2.Visible = true;//visible boton respuesta1
                Nivel2.Rows[1].Cells[0].Value = null;
                Nivel2.Rows[1].Cells[0].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[2].Cells[0].Value = null;
                Nivel2.Rows[2].Cells[0].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[3].Cells[0].Value = null;
                Nivel2.Rows[3].Cells[0].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[4].Cells[0].Value = null;
                Nivel2.Rows[4].Cells[0].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[5].Cells[0].Value = null;
                Nivel2.Rows[5].Cells[0].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[6].Cells[0].Value = null;
                Nivel2.Rows[6].Cells[0].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[0].Cells[1].Value = null;
                Nivel2.Rows[0].Cells[1].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[1].Cells[1].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[1].Cells[1].Value = null;
                Nivel2.Rows[2].Cells[1].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[2].Cells[1].Value = null;
                Nivel2.Rows[3].Cells[1].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[3].Cells[1].Value = null;
                Nivel2.Rows[6].Cells[1].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[6].Cells[1].Value = null;
                Nivel2.Rows[0].Cells[2].Style.BackColor = Color.SkyBlue;


                Nivel2.Rows[0].Cells[2].Value = null;
                Nivel2.Rows[2].Cells[2].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[2].Cells[2].Value = null;
                Nivel2.Rows[3].Cells[2].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[3].Cells[2].Value = null;
                Nivel2.Rows[4].Cells[2].Value = null;
                Nivel2.Rows[4].Cells[2].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[6].Cells[2].Value = null;
                Nivel2.Rows[6].Cells[2].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[7].Cells[2].Value = null;
                Nivel2.Rows[7].Cells[2].Style.BackColor = Color.SkyBlue;


                Nivel2.Rows[8].Cells[2].Value = null;
                Nivel2.Rows[8].Cells[2].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[1].Cells[3].Value = null;
                Nivel2.Rows[1].Cells[3].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[3].Cells[3].Value = null;
                Nivel2.Rows[3].Cells[3].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[4].Cells[3].Value = null;
                Nivel2.Rows[4].Cells[3].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[5].Cells[3].Value = null;
                Nivel2.Rows[5].Cells[3].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[6].Cells[3].Value = null;
                Nivel2.Rows[6].Cells[3].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[7].Cells[3].Value = null;
                Nivel2.Rows[7].Cells[3].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[1].Cells[4].Value = null;
                Nivel2.Rows[1].Cells[4].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[4].Cells[4].Value = null;
                Nivel2.Rows[4].Cells[4].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[6].Cells[4].Value = null;
                Nivel2.Rows[6].Cells[4].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[7].Cells[4].Value = null;
                Nivel2.Rows[7].Cells[4].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[8].Cells[4].Value = null;
                Nivel2.Rows[8].Cells[4].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[1].Cells[5].Value = null;
                Nivel2.Rows[1].Cells[5].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[3].Cells[5].Value = null;
                Nivel2.Rows[3].Cells[5].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[4].Cells[5].Value = null;
                Nivel2.Rows[4].Cells[5].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[7].Cells[5].Value = null;
                Nivel2.Rows[7].Cells[5].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[8].Cells[5].Value = null;
                Nivel2.Rows[8].Cells[5].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[0].Cells[6].Value = null;
                Nivel2.Rows[0].Cells[6].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[2].Cells[6].Value = null;
                Nivel2.Rows[2].Cells[6].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[5].Cells[6].Value = null;
                Nivel2.Rows[5].Cells[6].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[6].Cells[6].Value = null;
                Nivel2.Rows[6].Cells[6].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[7].Cells[6].Value = null;
                Nivel2.Rows[7].Cells[6].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[8].Cells[6].Value = null;
                Nivel2.Rows[8].Cells[6].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[0].Cells[7].Value = null;
                Nivel2.Rows[0].Cells[7].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[3].Cells[7].Value = null;
                Nivel2.Rows[3].Cells[7].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[4].Cells[7].Value = null;
                Nivel2.Rows[4].Cells[7].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[5].Cells[7].Value = null;
                Nivel2.Rows[5].Cells[7].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[8].Cells[7].Value = null;
                Nivel2.Rows[8].Cells[7].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[0].Cells[8].Value = null;
                Nivel2.Rows[0].Cells[8].Style.BackColor = Color.SkyBlue;
                Nivel2.Rows[1].Cells[8].Value = null;
                Nivel2.Rows[1].Cells[8].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[5].Cells[8].Value = null;
                Nivel2.Rows[5].Cells[8].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[6].Cells[8].Value = null;
                Nivel2.Rows[6].Cells[8].Style.BackColor = Color.SkyBlue;

                Nivel2.Rows[8].Cells[8].Value = null;
                Nivel2.Rows[8].Cells[8].Style.BackColor = Color.SkyBlue;
            }


            else { }

        }



        //......................................Metodos de tercera  Matriz del Nivel Dificil...................................................

        //filas y columnas del sudoku
        private void Datagriview3()
        {
            Nivel3.ColumnCount = 9;//define el numero de columnas
            DataGridViewColumn columna1 = Nivel3.Columns[0];

            columna1.Width = 45;//define el largo de la columnas
            DataGridViewColumn columna2 = Nivel3.Columns[1];
            columna2.Width = 45;
            DataGridViewColumn columna3 = Nivel3.Columns[2];
            columna3.Width = 45;
            DataGridViewColumn columna4 = Nivel3.Columns[3];
            columna4.Width = 45;
            DataGridViewColumn columna5 = Nivel3.Columns[4];
            columna5.Width = 45;
            DataGridViewColumn columna6 = Nivel3.Columns[5];
            columna6.Width = 45;
            DataGridViewColumn columna7 = Nivel3.Columns[6];
            columna7.Width = 45;
            DataGridViewColumn columna8 = Nivel3.Columns[7];
            columna8.Width = 45;
            DataGridViewColumn columna9 = Nivel3.Columns[8];
            columna9.Width = 45;
            Nivel3.Size = new Size(408, 408);//define el tamaño del data grid

            Nivel3.GridColor = Color.Red;//Define el color de los bordes del los cuadritos del datagridview
            Nivel3.BackgroundColor = Color.Red;//color del contorno del cuadro
        }
        //crea los espacios vacios en data grid y es donde oculta las respuestas

        private void tx_respuesta_nivel3_Click(object sender, EventArgs e)
        {
           //inicializa el reloj
            timer1.Stop();
            //Convierte espacios vacios
            tx_respuesta_nivel1.Visible = false;
            tx_respuesta_nivel2.Visible = false;
            tx_respuesta_nivel3.Visible = true;
            tx_respuesta_nivel4.Visible = false;
            tx_nuevo_juego.Visible = true;
           lb_mensaje.Visible =false;
            Respuestas_Visibles3();
            Asperdido.Visible = true;
        }
        //Metodo que valida si estan correctas 
        private void Nivel3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nivel3.Rows[e.RowIndex].ReadOnly = true;
            if (Nivel3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//entra a esta condicion si es nulo se pueden escribir numeros
            {
                Nivel3.Rows[e.RowIndex].ReadOnly = false;
                lb_mensaje.Visible = true;
               

            }
           
        }
        //Metodo que me valida si es correcto con un clic y les da color a los que estan buenas
        private void Nivel3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {

            }
            else
            {

                string posiblerespuesta = e.FormattedValue.ToString();//posible respuestas
                int val = Convert.ToInt32(posiblerespuesta);//convierto a strin

                if (val == Matriz3dificil[e.RowIndex, e.ColumnIndex])
                {
                   
                    Nivel3.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.SlateGray;//da este color a las respuestas correctas


                }
                else
                    Nivel3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;//si es nulo las deja como estan

            }
            if (//este if validas todos para saber si gano o tiene que seguir jugando,tiene que cumplirse todas
            Nivel3.Rows[1].Cells[0].Style.BackColor == Color.SlateGray&&
           
            Nivel3.Rows[2].Cells[0].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[3].Cells[0].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[4].Cells[0].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[5].Cells[0].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[6].Cells[0].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[7].Cells[0].Style.BackColor == Color.SlateGray &&
            Nivel3.Rows[8].Cells[0].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[0].Cells[1].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[1].Cells[1].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[2].Cells[1].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[4].Cells[1].Style.BackColor == Color.SlateGray &&



            Nivel3.Rows[5].Cells[1].Style.BackColor == Color. SlateGray && 
     
            Nivel3.Rows[7].Cells[1].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[1].Cells[2].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[2].Cells[2].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[4].Cells[2].Style.BackColor == Color.SlateGray &&



            Nivel3.Rows[7].Cells[2].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[0].Cells[3].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[1].Cells[3].Style.BackColor == Color.SlateGray &&
            Nivel3.Rows[2].Cells[3].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[3].Cells[3].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[5].Cells[3].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[6].Cells[3].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[7].Cells[3].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[8].Cells[3].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[0].Cells[4].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[2].Cells[4].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[3].Cells[4].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[4].Cells[4].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[5].Cells[4].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[7].Cells[4].Style.BackColor == Color.SlateGray &&
            Nivel3.Rows[8].Cells[4].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[0].Cells[5].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[1].Cells[5].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[2].Cells[5].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[4].Cells[5].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[7].Cells[5].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[8].Cells[5].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[0].Cells[6].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[2].Cells[6].Style.BackColor ==Color.SlateGray &&


            Nivel3.Rows[3].Cells[6].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[4].Cells[6].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[5].Cells[6].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[6].Cells[6].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[7].Cells[6].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[8].Cells[6].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[0].Cells[7].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[1].Cells[7].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[2].Cells[7].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[3].Cells[7].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[5].Cells[7].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[6].Cells[7].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[0].Cells[8].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[1].Cells[8].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[2].Cells[8].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[3].Cells[8].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[4].Cells[8].Style.BackColor == Color.SlateGray &&

            Nivel3.Rows[5].Cells[8].Style.BackColor == Color.SlateGray &&


            Nivel3.Rows[6].Cells[8].Style.BackColor == Color.SlateGray 

              )


            {
                
                lb_mensaje.Text = "❤‿❤ GANASTES ❤‿❤";//mensaje cuando se gana el juego
            
               
                

            }

            else
            {
                lb_mensaje.Text = "SIGA JUGANDO!";//mensaje que siga jugando el juego
               
            }
          

        }


        //muestra las tablas del tadagridview
        private void Tablas3(int[,] soluciones, int dificultades)
        {
            var numfilas = 9;//numero de filas
            var numcolumnas = 9;//numeros de columnas

            for (int pocisionfila = 0; pocisionfila < numfilas; ++pocisionfila)//recorre las posiciones de las filas
            {
                var filas = new DataGridViewRow();//declaro la fila para el datagrid
                filas.Height = 45;//ancho de las columnas
                for (int pocisioncolumnas = 0; pocisioncolumnas < numcolumnas; ++pocisioncolumnas)//for que correcore las columas
                {


                    filas.Cells.Add(new DataGridViewTextBoxCell()//agrega las columnas al data grid
                    {
                        Value = soluciones[pocisionfila, pocisioncolumnas]//evalua las posiciones de las filas y columnas
                    });


                }

                Nivel3.Rows.Add(filas);//Agrega las filas

            }



        }




        //valida las respuestas
        private void Respuestas_Visibles3()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Nivel3.Rows[i].Cells[j].Value = Matriz3dificil[i, j];//los llena con la respuesta correcta los cuadros
                    Nivel3.Rows[i].Cells[j].Style.BackColor = Color.SlateGray;//da color a las respuestas correctas
                   
                }
            }
        }


        //crea los espacios vacios en data grid y es donde oculta las respuestas

        private void Respuestas_Invisibles3(int level)
        {
            Respuestas_Visibles3();//llama a los que estan visibles

            //entra al tercer nivel y le da colores a los espacios emn blancos

            if (level == 2)
            {
                timer1.Start();
                tx_respuesta_nivel3.Visible = true;//visible boton respuesta1
                Nivel3.Visible = true;
                paratercernivel.Visible = true;
                bt_ayuda.Visible = true;
                Reiniciar.Visible = true;
                check.Visible = true;
              
                //convierte los espacios en nilos y les da color
                Nivel3.Rows[1].Cells[0].Value = null;
                Nivel3.Rows[1].Cells[0].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[0].Value = null;
                Nivel3.Rows[2].Cells[0].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[0].Value = null;
                Nivel3.Rows[3].Cells[0].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[4].Cells[0].Value = null;
                Nivel3.Rows[4].Cells[0].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[0].Value = null;
                Nivel3.Rows[5].Cells[0].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[6].Cells[0].Value = null;
                Nivel3.Rows[6].Cells[0].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[7].Cells[0].Value = null;
                Nivel3.Rows[7].Cells[0].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[8].Cells[0].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[8].Cells[0].Value = null;
                Nivel3.Rows[0].Cells[1].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[0].Cells[1].Value = null;
                Nivel3.Rows[1].Cells[1].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[1].Cells[1].Value = null;
                Nivel3.Rows[2].Cells[1].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[1].Value = null;
                Nivel3.Rows[4].Cells[1].Style.BackColor = Color.LightSlateGray;


                Nivel3.Rows[4].Cells[1].Value = null;
                Nivel3.Rows[5].Cells[1].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[1].Value = null;
                Nivel3.Rows[7].Cells[1].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[7].Cells[1].Value = null;
                Nivel3.Rows[1].Cells[2].Value = null;
                Nivel3.Rows[1].Cells[2].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[2].Value = null;
                Nivel3.Rows[2].Cells[2].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[4].Cells[2].Value = null;
                Nivel3.Rows[4].Cells[2].Style.BackColor = Color.LightSlateGray;


                Nivel3.Rows[7].Cells[2].Value = null;
                Nivel3.Rows[7].Cells[2].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[0].Cells[3].Value = null;
                Nivel3.Rows[0].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[1].Cells[3].Value = null;
                Nivel3.Rows[1].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[3].Value = null;
                Nivel3.Rows[2].Cells[3].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[3].Value = null;
                Nivel3.Rows[3].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[3].Value = null;
                Nivel3.Rows[5].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[6].Cells[3].Value = null;
                Nivel3.Rows[6].Cells[3].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[7].Cells[3].Value = null;
                Nivel3.Rows[7].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[8].Cells[3].Value = null;
                Nivel3.Rows[8].Cells[3].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[0].Cells[4].Value = null;
                Nivel3.Rows[0].Cells[4].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[4].Value = null;
                Nivel3.Rows[2].Cells[4].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[4].Value = null;
                Nivel3.Rows[3].Cells[4].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[4].Cells[4].Value = null;
                Nivel3.Rows[4].Cells[4].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[4].Value = null;
                Nivel3.Rows[5].Cells[4].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[7].Cells[4].Value = null;
                Nivel3.Rows[7].Cells[4].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[8].Cells[4].Value = null;
                Nivel3.Rows[8].Cells[4].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[0].Cells[5].Value = null;
                Nivel3.Rows[0].Cells[5].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[1].Cells[5].Value = null;
                Nivel3.Rows[1].Cells[5].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[5].Value = null;
                Nivel3.Rows[2].Cells[5].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[4].Cells[5].Value = null;
                Nivel3.Rows[4].Cells[5].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[7].Cells[5].Value = null;
                Nivel3.Rows[7].Cells[5].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[8].Cells[5].Value = null;
                Nivel3.Rows[8].Cells[5].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[0].Cells[6].Value = null;
                Nivel3.Rows[0].Cells[6].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[6].Value = null;
                Nivel3.Rows[2].Cells[6].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[6].Value = null;
                Nivel3.Rows[3].Cells[6].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[4].Cells[6].Value = null;
                Nivel3.Rows[4].Cells[6].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[6].Value = null;
                Nivel3.Rows[5].Cells[6].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[6].Cells[6].Value = null;
                Nivel3.Rows[6].Cells[6].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[7].Cells[6].Value = null;
                Nivel3.Rows[7].Cells[6].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[8].Cells[6].Value = null;
                Nivel3.Rows[8].Cells[6].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[0].Cells[7].Value = null;
                Nivel3.Rows[0].Cells[7].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[1].Cells[7].Value = null;
                Nivel3.Rows[1].Cells[7].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[2].Cells[7].Value = null;
                Nivel3.Rows[2].Cells[7].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[7].Value = null;
                Nivel3.Rows[3].Cells[7].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[5].Cells[7].Value = null;
                Nivel3.Rows[5].Cells[7].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[6].Cells[7].Value = null;
                Nivel3.Rows[6].Cells[7].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[0].Cells[8].Value = null;
                Nivel3.Rows[0].Cells[8].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[1].Cells[8].Value = null;
                Nivel3.Rows[1].Cells[8].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[2].Cells[8].Value = null;
                Nivel3.Rows[2].Cells[8].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[3].Cells[8].Value = null;
                Nivel3.Rows[3].Cells[8].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[4].Cells[8].Value = null;
                Nivel3.Rows[4].Cells[8].Style.BackColor = Color.LightSlateGray;
                Nivel3.Rows[5].Cells[8].Value = null;
                Nivel3.Rows[5].Cells[8].Style.BackColor = Color.LightSlateGray;

                Nivel3.Rows[6].Cells[8].Value = null;
                Nivel3.Rows[6].Cells[8].Style.BackColor = Color.LightSlateGray;


            }

            else { }

        }





        //......................................Metodos de segunda Matriz del muy dificil...................................................


        //filas y columnas del sudoku
        private void Datagriview4()
        {
            Nivel4.ColumnCount = 9;//define el numero de columnas
            DataGridViewColumn columna1 = Nivel4.Columns[0];

            columna1.Width = 45;//define el largo de la columnas
            DataGridViewColumn columna2 = Nivel4.Columns[1];
            columna2.Width = 45;
            DataGridViewColumn columna3 = Nivel4.Columns[2];
            columna3.Width = 45;
            DataGridViewColumn columna4 = Nivel4.Columns[3];
            columna4.Width = 45;
            DataGridViewColumn columna5 = Nivel4.Columns[4];
            columna5.Width = 45;
            DataGridViewColumn columna6 = Nivel4.Columns[5];
            columna6.Width = 45;
            DataGridViewColumn columna7 = Nivel4.Columns[6];
            columna7.Width = 45;
            DataGridViewColumn columna8 = Nivel4.Columns[7];
            columna8.Width = 45;
            DataGridViewColumn columna9 = Nivel4.Columns[8];
            columna9.Width = 45;
            Nivel4.Size = new Size(408, 408);//define el tamaño del data grid

            Nivel4.GridColor = Color.White;//Define el color de los bordes del los cuadritos del datagridview
            Nivel4.BackgroundColor = Color.White;//color del contorno del cuadro
            Nivel4.ForeColor = Color.OrangeRed;//DA EL COLOR a los numeros
        }
        //Metodo que permite escribir los numeros en los espacios en nulos
        private void Nivel4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nivel4.Rows[e.RowIndex].ReadOnly = true;
            if (Nivel4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)//entra a la condicion
            {
                Nivel4.Rows[e.RowIndex].ReadOnly = false;//me permite escribir mis espacios en nulos
                lb_mensaje.Visible = true;
            }
          
        }

        //valida los campos del data griview
        private void Nivel4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))//permite dar color a las respuesta correctas y las valida
            {

            }
            else
            {

                string posiblerespuesta = e.FormattedValue.ToString();//posible respuestas
                int val = Convert.ToInt32(posiblerespuesta);//convierto a strin

                if (val == Matriz4muydificil[e.RowIndex, e.ColumnIndex])
                {
                  
                    Nivel4.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Navy;//da color


                }
                else
                   Nivel4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;//si es nulo queda igual
             

            }
            if (//este if se cumple solo si todas esta casillas estan un mismo color
            Nivel4.Rows[1].Cells[0].Style.BackColor == Color.Navy&&
           
            Nivel4.Rows[2].Cells[0].Style.BackColor == Color.Navy &&


            Nivel4.Rows[3].Cells[0].Style.BackColor == Color.Navy &&


            Nivel4.Rows[4].Cells[0].Style.BackColor == Color.Navy &&

            Nivel4.Rows[5].Cells[0].Style.BackColor == Color.Navy &&


            Nivel4.Rows[6].Cells[0].Style.BackColor == Color.Navy &&

            Nivel4.Rows[7].Cells[0].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[1].Style.BackColor == Color.Navy &&
             Nivel4.Rows[4].Cells[1].Style.BackColor == Color.Navy &&
            Nivel4.Rows[1].Cells[1].Style.BackColor == Color.Navy &&


            Nivel4.Rows[2].Cells[1].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[1].Style.BackColor == Color.Navy &&



            Nivel4.Rows[6].Cells[1].Style.BackColor == Color.Navy &&

            Nivel4.Rows[8].Cells[1].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[2].Style.BackColor == Color.Navy &&



            Nivel4.Rows[2].Cells[2].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[2].Style.BackColor == Color.Navy&&
           
          
            Nivel4.Rows[4].Cells[2].Style.BackColor == Color.Navy &&

            Nivel4.Rows[5].Cells[2].Style.BackColor == Color.Navy &&

            Nivel4.Rows[6].Cells[2].Style.BackColor == Color.Navy &&

            Nivel4.Rows[7].Cells[2].Style.BackColor == Color.Navy &&



            Nivel4.Rows[8].Cells[2].Style.BackColor == Color.Navy &&

            Nivel4.Rows[1].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[2].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[4].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[5].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[6].Cells[3].Style.BackColor == Color.Navy &&


            Nivel4.Rows[7].Cells[3].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[1].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[4].Cells[4].Style.BackColor == Color.Navy &&


            Nivel4.Rows[6].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[7].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[8].Cells[4].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[5].Style.BackColor == Color.Navy &&

            Nivel4.Rows[1].Cells[5].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[5].Style.BackColor == Color.Navy &&

            Nivel4.Rows[4].Cells[5].Style.BackColor == Color.Navy &&


            Nivel4.Rows[7].Cells[5].Style.BackColor == Color.Navy &&

            Nivel4.Rows[8].Cells[5].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[6].Style.BackColor == Color.Navy &&

            Nivel4.Rows[2].Cells[6].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[6].Style.BackColor == Color.Navy &&

            Nivel4.Rows[5].Cells[6].Style.BackColor == Color.Navy &&


            Nivel4.Rows[6].Cells[6].Style.BackColor == Color.Navy &&

            Nivel4.Rows[7].Cells[6].Style.BackColor == Color.Navy &&

            Nivel4.Rows[8].Cells[6].Style.BackColor == Color.Navy &&


            Nivel4.Rows[0].Cells[7].Style.BackColor == Color.Navy &&

            Nivel4.Rows[1].Cells[7].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[7].Style.BackColor == Color.Navy &&

            Nivel4.Rows[4].Cells[7].Style.BackColor == Color.Navy &&


            Nivel4.Rows[5].Cells[7].Style.BackColor == Color.Navy &&

            Nivel4.Rows[6].Cells[7].Style.BackColor == Color.Navy &&


            Nivel4.Rows[8].Cells[7].Style.BackColor == Color.Navy &&

            Nivel4.Rows[0].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[1].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[2].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[3].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[5].Cells[8].Style.BackColor == Color.Navy &&


            Nivel4.Rows[6].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[7].Cells[8].Style.BackColor == Color.Navy &&

            Nivel4.Rows[8].Cells[8].Style.BackColor == Color.Navy 
               )


            {
              
                lb_mensaje.Text = "❤‿❤ GANASTES ❤‿❤";//mensaje cuando se gana el juego
               
            }

            else
            {
                lb_mensaje.Text = "SIGA JUGANDO!";//mensaje que me dice que siga jugando

            }


        }

        //muestra las tablas del tadagridview
        private void Tablas4(int[,] soluciones, int dificultades)
        {
            var numfilas = 9;//numero de filas
            var numcolumnas = 9;//numeros de columnas

            for (int pocisionfila = 0; pocisionfila < numfilas; ++pocisionfila)//recorre las posiciones de las filas
            {
                var filas = new DataGridViewRow();//declaro la fila para el datagrid
                filas.Height = 45;//ancho de las columnas
                for (int pocisioncolumnas = 0; pocisioncolumnas < numcolumnas; ++pocisioncolumnas)//for que correcore las columas
                {


                    filas.Cells.Add(new DataGridViewTextBoxCell()//agrega las columnas al data grid
                    {
                        Value = soluciones[pocisionfila, pocisioncolumnas]//evalua las posiciones de las filas y columnas
                    });


                }

                Nivel4.Rows.Add(filas);//Agrega las filas

            }



        }

        private void Nivel4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Nivel3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n                  ◕◡◕INSTRUCCIONES ◕◡◕        " +
"\n\nEste juego está compuesto por una cuadrícula de 9x9 casillas, dividida en regiones de 3x3 casillas. Partiendo de algunos números ya dispuestos en algunas de las casillas, hay que completar las casillas vacías con dígitos del 1 al 9 sin que se repitan por fila, columna o región." +

"\nReglas:" +

"\nRegla 1: hay que completar las casillas vacías con un solo número del 1 al 9." +

"\nRegla 2: en una misma fila no puede haber números repetidos." +

"\nRegla 3: en una misma columna no puede haber números repetidos." +

"\nRegla 4: en una misma región no puede haber números repetidos." +

"\nRegla 5: la solución de un sudoku es única. ", " SUDOKU ",MessageBoxButtons.OK, MessageBoxIcon.Information);

           
           
        }

        private void paracuartonivel_Click(object sender, EventArgs e)
        {

        }


        //valida las respuestas
        private void Respuestas_Visibles5()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Nivel4.Rows[i].Cells[j].Value = Matriz4muydificil[i, j];//los llena con la respuesta correcta los cuadros
                    Nivel4.Rows[i].Cells[j].Style.BackColor = Color.Navy;
                }
            }
        }


        private void tx_respuesta_nivel4_Click(object sender, EventArgs e)
        {
            //Respuestas del nivel 4,son los botones que se pueden mostrar
            timer1.Stop();
            tx_respuesta_nivel1.Visible = false;
            tx_respuesta_nivel2.Visible = false;
            tx_respuesta_nivel3.Visible = false;
            tx_respuesta_nivel4.Visible = true;
            tx_nuevo_juego.Visible = true;
             lb_mensaje.Visible = false;
            Asperdido.Visible = true;
            Respuestas_Visibles5();
        }
        //crea los espacios vacios en data grid y es donde oculta las respuestas

        private void Respuestas_Invisibles5(int level)
        {
            Respuestas_Visibles5();//llama a los que estan visibles


                //nivel muy dificil
                if (level == 3)
            {
                timer1.Start();
                check.Visible = true;
                bt_ayuda.Visible = true;
                Reiniciar.Visible = true;
                tx_respuesta_nivel4.Visible = true;//visible boton respuesta1
                paracuartonivel.Visible = true;
                Nivel4.Visible = true;
                Nivel4.Rows[1].Cells[0].Value = null;
                Nivel4.Rows[1].Cells[0].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[0].Value = null;
                Nivel4.Rows[2].Cells[0].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[3].Cells[0].Value = null;
                Nivel4.Rows[3].Cells[0].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[4].Cells[0].Value = null;
                Nivel4.Rows[4].Cells[0].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[4].Cells[1].Value = null;
                Nivel4.Rows[4].Cells[1].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[5].Cells[0].Value = null;
                Nivel4.Rows[5].Cells[0].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[6].Cells[0].Value = null;
                Nivel4.Rows[6].Cells[0].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[7].Cells[0].Value = null;
                Nivel4.Rows[7].Cells[0].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[0].Cells[1].Value = null;
                Nivel4.Rows[0].Cells[1].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[1].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[1].Cells[1].Value = null;
                Nivel4.Rows[2].Cells[1].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[1].Value = null;
                Nivel4.Rows[3].Cells[1].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[3].Cells[1].Value = null;

                Nivel4.Rows[6].Cells[1].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[6].Cells[1].Value = null;
                Nivel4.Rows[8].Cells[1].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[8].Cells[1].Value = null;
                Nivel4.Rows[0].Cells[2].Style.BackColor = Color.DarkBlue;


                Nivel4.Rows[0].Cells[2].Value = null;
                Nivel4.Rows[2].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[2].Value = null;
                Nivel4.Rows[3].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[2].Value = null;
                Nivel4.Rows[4].Cells[2].Value = null;
                Nivel4.Rows[4].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[5].Cells[2].Value = null;
                Nivel4.Rows[5].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[6].Cells[2].Value = null;
                Nivel4.Rows[6].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[7].Cells[2].Value = null;
                Nivel4.Rows[7].Cells[2].Style.BackColor = Color.DarkBlue;


                Nivel4.Rows[8].Cells[2].Value = null;
                Nivel4.Rows[8].Cells[2].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[3].Value = null;
                Nivel4.Rows[1].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[3].Value = null;
                Nivel4.Rows[2].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[3].Value = null;
                Nivel4.Rows[3].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[4].Cells[3].Value = null;
                Nivel4.Rows[4].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[5].Cells[3].Value = null;
                Nivel4.Rows[5].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[6].Cells[3].Value = null;
                Nivel4.Rows[6].Cells[3].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[7].Cells[3].Value = null;
                Nivel4.Rows[7].Cells[3].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[0].Cells[4].Value = null;
                Nivel4.Rows[0].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[4].Value = null;
                Nivel4.Rows[1].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[4].Value = null;
                Nivel4.Rows[3].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[4].Cells[4].Value = null;
                Nivel4.Rows[4].Cells[4].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[6].Cells[4].Value = null;
                Nivel4.Rows[6].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[7].Cells[4].Value = null;
                Nivel4.Rows[7].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[8].Cells[4].Value = null;
                Nivel4.Rows[8].Cells[4].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[0].Cells[5].Value = null;
                Nivel4.Rows[0].Cells[5].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[5].Value = null;
                Nivel4.Rows[1].Cells[5].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[5].Value = null;
                Nivel4.Rows[3].Cells[5].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[4].Cells[5].Value = null;
                Nivel4.Rows[4].Cells[5].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[7].Cells[5].Value = null;
                Nivel4.Rows[7].Cells[5].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[8].Cells[5].Value = null;
                Nivel4.Rows[8].Cells[5].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[0].Cells[6].Value = null;
                Nivel4.Rows[0].Cells[6].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[6].Value = null;
                Nivel4.Rows[2].Cells[6].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[6].Value = null;
                Nivel4.Rows[3].Cells[6].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[5].Cells[6].Value = null;
                Nivel4.Rows[5].Cells[6].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[6].Cells[6].Value = null;
                Nivel4.Rows[6].Cells[6].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[7].Cells[6].Value = null;
                Nivel4.Rows[7].Cells[6].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[8].Cells[6].Value = null;
                Nivel4.Rows[8].Cells[6].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[0].Cells[7].Value = null;
                Nivel4.Rows[0].Cells[7].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[7].Value = null;
                Nivel4.Rows[1].Cells[7].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[7].Value = null;
                Nivel4.Rows[3].Cells[7].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[4].Cells[7].Value = null;
                Nivel4.Rows[4].Cells[7].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[5].Cells[7].Value = null;
                Nivel4.Rows[5].Cells[7].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[6].Cells[7].Value = null;
                Nivel4.Rows[6].Cells[7].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[8].Cells[7].Value = null;
                Nivel4.Rows[8].Cells[7].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[0].Cells[8].Value = null;
                Nivel4.Rows[0].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[1].Cells[8].Value = null;
                Nivel4.Rows[1].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[2].Cells[8].Value = null;
                Nivel4.Rows[2].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[3].Cells[8].Value = null;
                Nivel4.Rows[3].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[5].Cells[8].Value = null;
                Nivel4.Rows[5].Cells[8].Style.BackColor = Color.DarkBlue;

                Nivel4.Rows[6].Cells[8].Value = null;
                Nivel4.Rows[6].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[7].Cells[8].Value = null;
                Nivel4.Rows[7].Cells[8].Style.BackColor = Color.DarkBlue;
                Nivel4.Rows[8].Cells[8].Value = null;
                Nivel4.Rows[8].Cells[8].Style.BackColor = Color.DarkBlue;

            }


                else { }

            }

        private void Reiniciar_Click(object sender, EventArgs e)//Metodo que reinicia el juego
        {//Primera Matriz limpia los cuadros
         //limpia los label de la hora
            timer1.Start();
            Asperdido.Visible = false;
            milesegundos = 0;
            i_Sec = 0;
            i_Min = 0;
            i_Hour = 0;//variables de minutos
                       //variables me convierten a cero el cronometro para que vuelva a empezar
            lbl_Txt_Hours.Text = 0.ToString();
            lbl_Txt_Mins.Text = 0.ToString();
            lbl_Txt_Secs.Text = 0.ToString();


            datagridview_juego_cuadro.Rows[2].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[2].Cells[0].Style.BackColor = Color.Magenta;//da color al cuadro vacio
            datagridview_juego_cuadro.Rows[3].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[0].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[4].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[4].Cells[0].Style.BackColor = Color.Magenta;


            datagridview_juego_cuadro.Rows[5].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[5].Cells[0].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[6].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[6].Cells[0].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[7].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[7].Cells[0].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[8].Cells[0].Value = null;
            datagridview_juego_cuadro.Rows[8].Cells[0].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[2].Cells[1].Value = null;
            datagridview_juego_cuadro.Rows[2].Cells[1].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[3].Cells[1].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[1].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[5].Cells[1].Value = null;
            datagridview_juego_cuadro.Rows[5].Cells[1].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[6].Cells[1].Value = null;
            datagridview_juego_cuadro.Rows[6].Cells[1].Style.BackColor = Color.Magenta;


            datagridview_juego_cuadro.Rows[8].Cells[1].Value = null;
            datagridview_juego_cuadro.Rows[8].Cells[1].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[2].Cells[2].Value = null;
            datagridview_juego_cuadro.Rows[2].Cells[2].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[3].Cells[2].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[2].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[4].Cells[2].Value = null;
            datagridview_juego_cuadro.Rows[4].Cells[2].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[6].Cells[2].Value = null;
            datagridview_juego_cuadro.Rows[6].Cells[2].Style.BackColor = Color.Magenta;


            datagridview_juego_cuadro.Rows[4].Cells[3].Value = null;
            datagridview_juego_cuadro.Rows[4].Cells[3].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[0].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[0].Cells[4].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[1].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[1].Cells[4].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[3].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[4].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[4].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[4].Cells[4].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[5].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[5].Cells[4].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[8].Cells[4].Value = null;
            datagridview_juego_cuadro.Rows[8].Cells[4].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[0].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[0].Cells[5].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[1].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[1].Cells[5].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[3].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[5].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[6].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[6].Cells[5].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[7].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[7].Cells[5].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[8].Cells[5].Value = null;
            datagridview_juego_cuadro.Rows[8].Cells[5].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[6].Cells[7].Value = null;
            datagridview_juego_cuadro.Rows[6].Cells[7].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[7].Cells[7].Value = null;
            datagridview_juego_cuadro.Rows[7].Cells[7].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[8].Cells[7].Value = null;
            datagridview_juego_cuadro.Rows[8].Cells[7].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[3].Cells[8].Value = null;
            datagridview_juego_cuadro.Rows[3].Cells[8].Style.BackColor = Color.Magenta;
            datagridview_juego_cuadro.Rows[4].Cells[8].Value = null;
            datagridview_juego_cuadro.Rows[4].Cells[8].Style.BackColor = Color.Magenta;

            datagridview_juego_cuadro.Rows[5].Cells[8].Value = null;
            datagridview_juego_cuadro.Rows[5].Cells[8].Style.BackColor = Color.Magenta;



            //---------------------------------------segunda Matriz-----------------------------------------------------------
            Nivel2.Rows[1].Cells[0].Value = null;
            Nivel2.Rows[1].Cells[0].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[2].Cells[0].Value = null;
            Nivel2.Rows[2].Cells[0].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[3].Cells[0].Value = null;
            Nivel2.Rows[3].Cells[0].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[4].Cells[0].Value = null;
            Nivel2.Rows[4].Cells[0].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[5].Cells[0].Value = null;
            Nivel2.Rows[5].Cells[0].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[6].Cells[0].Value = null;
            Nivel2.Rows[6].Cells[0].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[0].Cells[1].Value = null;
            Nivel2.Rows[0].Cells[1].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[1].Cells[1].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[1].Cells[1].Value = null;
            Nivel2.Rows[2].Cells[1].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[2].Cells[1].Value = null;
            Nivel2.Rows[3].Cells[1].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[3].Cells[1].Value = null;
            Nivel2.Rows[6].Cells[1].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[6].Cells[1].Value = null;
            Nivel2.Rows[0].Cells[2].Style.BackColor = Color.SkyBlue;


            Nivel2.Rows[0].Cells[2].Value = null;
            Nivel2.Rows[2].Cells[2].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[2].Cells[2].Value = null;
            Nivel2.Rows[3].Cells[2].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[3].Cells[2].Value = null;
            Nivel2.Rows[4].Cells[2].Value = null;
            Nivel2.Rows[4].Cells[2].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[6].Cells[2].Value = null;
            Nivel2.Rows[6].Cells[2].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[7].Cells[2].Value = null;
            Nivel2.Rows[7].Cells[2].Style.BackColor = Color.SkyBlue;


            Nivel2.Rows[8].Cells[2].Value = null;
            Nivel2.Rows[8].Cells[2].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[1].Cells[3].Value = null;
            Nivel2.Rows[1].Cells[3].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[3].Cells[3].Value = null;
            Nivel2.Rows[3].Cells[3].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[4].Cells[3].Value = null;
            Nivel2.Rows[4].Cells[3].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[5].Cells[3].Value = null;
            Nivel2.Rows[5].Cells[3].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[6].Cells[3].Value = null;
            Nivel2.Rows[6].Cells[3].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[7].Cells[3].Value = null;
            Nivel2.Rows[7].Cells[3].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[1].Cells[4].Value = null;
            Nivel2.Rows[1].Cells[4].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[4].Cells[4].Value = null;
            Nivel2.Rows[4].Cells[4].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[6].Cells[4].Value = null;
            Nivel2.Rows[6].Cells[4].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[7].Cells[4].Value = null;
            Nivel2.Rows[7].Cells[4].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[8].Cells[4].Value = null;
            Nivel2.Rows[8].Cells[4].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[1].Cells[5].Value = null;
            Nivel2.Rows[1].Cells[5].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[3].Cells[5].Value = null;
            Nivel2.Rows[3].Cells[5].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[4].Cells[5].Value = null;
            Nivel2.Rows[4].Cells[5].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[7].Cells[5].Value = null;
            Nivel2.Rows[7].Cells[5].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[8].Cells[5].Value = null;
            Nivel2.Rows[8].Cells[5].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[0].Cells[6].Value = null;
            Nivel2.Rows[0].Cells[6].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[2].Cells[6].Value = null;
            Nivel2.Rows[2].Cells[6].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[5].Cells[6].Value = null;
            Nivel2.Rows[5].Cells[6].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[6].Cells[6].Value = null;
            Nivel2.Rows[6].Cells[6].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[7].Cells[6].Value = null;
            Nivel2.Rows[7].Cells[6].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[8].Cells[6].Value = null;
            Nivel2.Rows[8].Cells[6].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[0].Cells[7].Value = null;
            Nivel2.Rows[0].Cells[7].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[3].Cells[7].Value = null;
            Nivel2.Rows[3].Cells[7].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[4].Cells[7].Value = null;
            Nivel2.Rows[4].Cells[7].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[5].Cells[7].Value = null;
            Nivel2.Rows[5].Cells[7].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[8].Cells[7].Value = null;
            Nivel2.Rows[8].Cells[7].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[0].Cells[8].Value = null;
            Nivel2.Rows[0].Cells[8].Style.BackColor = Color.SkyBlue;
            Nivel2.Rows[1].Cells[8].Value = null;
            Nivel2.Rows[1].Cells[8].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[5].Cells[8].Value = null;
            Nivel2.Rows[5].Cells[8].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[6].Cells[8].Value = null;
            Nivel2.Rows[6].Cells[8].Style.BackColor = Color.SkyBlue;

            Nivel2.Rows[8].Cells[8].Value = null;
            Nivel2.Rows[8].Cells[8].Style.BackColor = Color.SkyBlue;

            //------------------------------------------------tercera Matriz--------------------------------------------------------
            Nivel3.Rows[1].Cells[0].Value = null;
            Nivel3.Rows[1].Cells[0].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[0].Value = null;
            Nivel3.Rows[2].Cells[0].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[0].Value = null;
            Nivel3.Rows[3].Cells[0].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[4].Cells[0].Value = null;
            Nivel3.Rows[4].Cells[0].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[0].Value = null;
            Nivel3.Rows[5].Cells[0].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[6].Cells[0].Value = null;
            Nivel3.Rows[6].Cells[0].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[7].Cells[0].Value = null;
            Nivel3.Rows[7].Cells[0].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[8].Cells[0].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[8].Cells[0].Value = null;
            Nivel3.Rows[0].Cells[1].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[0].Cells[1].Value = null;
            Nivel3.Rows[1].Cells[1].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[1].Cells[1].Value = null;
            Nivel3.Rows[2].Cells[1].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[1].Value = null;
            Nivel3.Rows[4].Cells[1].Style.BackColor = Color.LightSlateGray;


            Nivel3.Rows[4].Cells[1].Value = null;
            Nivel3.Rows[5].Cells[1].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[1].Value = null;
            Nivel3.Rows[7].Cells[1].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[7].Cells[1].Value = null;
            Nivel3.Rows[1].Cells[2].Value = null;
            Nivel3.Rows[1].Cells[2].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[2].Value = null;
            Nivel3.Rows[2].Cells[2].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[4].Cells[2].Value = null;
            Nivel3.Rows[4].Cells[2].Style.BackColor = Color.LightSlateGray;


            Nivel3.Rows[7].Cells[2].Value = null;
            Nivel3.Rows[7].Cells[2].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[0].Cells[3].Value = null;
            Nivel3.Rows[0].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[1].Cells[3].Value = null;
            Nivel3.Rows[1].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[3].Value = null;
            Nivel3.Rows[2].Cells[3].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[3].Value = null;
            Nivel3.Rows[3].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[3].Value = null;
            Nivel3.Rows[5].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[6].Cells[3].Value = null;
            Nivel3.Rows[6].Cells[3].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[7].Cells[3].Value = null;
            Nivel3.Rows[7].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[8].Cells[3].Value = null;
            Nivel3.Rows[8].Cells[3].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[0].Cells[4].Value = null;
            Nivel3.Rows[0].Cells[4].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[4].Value = null;
            Nivel3.Rows[2].Cells[4].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[4].Value = null;
            Nivel3.Rows[3].Cells[4].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[4].Cells[4].Value = null;
            Nivel3.Rows[4].Cells[4].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[4].Value = null;
            Nivel3.Rows[5].Cells[4].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[7].Cells[4].Value = null;
            Nivel3.Rows[7].Cells[4].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[8].Cells[4].Value = null;
            Nivel3.Rows[8].Cells[4].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[0].Cells[5].Value = null;
            Nivel3.Rows[0].Cells[5].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[1].Cells[5].Value = null;
            Nivel3.Rows[1].Cells[5].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[5].Value = null;
            Nivel3.Rows[2].Cells[5].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[4].Cells[5].Value = null;
            Nivel3.Rows[4].Cells[5].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[7].Cells[5].Value = null;
            Nivel3.Rows[7].Cells[5].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[8].Cells[5].Value = null;
            Nivel3.Rows[8].Cells[5].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[0].Cells[6].Value = null;
            Nivel3.Rows[0].Cells[6].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[6].Value = null;
            Nivel3.Rows[2].Cells[6].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[6].Value = null;
            Nivel3.Rows[3].Cells[6].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[4].Cells[6].Value = null;
            Nivel3.Rows[4].Cells[6].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[6].Value = null;
            Nivel3.Rows[5].Cells[6].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[6].Cells[6].Value = null;
            Nivel3.Rows[6].Cells[6].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[7].Cells[6].Value = null;
            Nivel3.Rows[7].Cells[6].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[8].Cells[6].Value = null;
            Nivel3.Rows[8].Cells[6].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[0].Cells[7].Value = null;
            Nivel3.Rows[0].Cells[7].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[1].Cells[7].Value = null;
            Nivel3.Rows[1].Cells[7].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[2].Cells[7].Value = null;
            Nivel3.Rows[2].Cells[7].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[7].Value = null;
            Nivel3.Rows[3].Cells[7].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[5].Cells[7].Value = null;
            Nivel3.Rows[5].Cells[7].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[6].Cells[7].Value = null;
            Nivel3.Rows[6].Cells[7].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[0].Cells[8].Value = null;
            Nivel3.Rows[0].Cells[8].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[1].Cells[8].Value = null;
            Nivel3.Rows[1].Cells[8].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[2].Cells[8].Value = null;
            Nivel3.Rows[2].Cells[8].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[3].Cells[8].Value = null;
            Nivel3.Rows[3].Cells[8].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[4].Cells[8].Value = null;
            Nivel3.Rows[4].Cells[8].Style.BackColor = Color.LightSlateGray;
            Nivel3.Rows[5].Cells[8].Value = null;
            Nivel3.Rows[5].Cells[8].Style.BackColor = Color.LightSlateGray;

            Nivel3.Rows[6].Cells[8].Value = null;
            Nivel3.Rows[6].Cells[8].Style.BackColor = Color.LightSlateGray;


            //--------------------------------cuarta Matriz---------------------------------------------------
            Nivel4.Rows[1].Cells[0].Value = null;
            Nivel4.Rows[1].Cells[0].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[0].Value = null;
            Nivel4.Rows[2].Cells[0].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[3].Cells[0].Value = null;
            Nivel4.Rows[3].Cells[0].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[1].Value = null;
            Nivel4.Rows[4].Cells[1].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[0].Value = null;
            Nivel4.Rows[4].Cells[0].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[5].Cells[0].Value = null;
            Nivel4.Rows[5].Cells[0].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[6].Cells[0].Value = null;
            Nivel4.Rows[6].Cells[0].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[7].Cells[0].Value = null;
            Nivel4.Rows[7].Cells[0].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[0].Cells[1].Value = null;
            Nivel4.Rows[0].Cells[1].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[1].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[1].Cells[1].Value = null;
            Nivel4.Rows[2].Cells[1].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[1].Value = null;
            Nivel4.Rows[3].Cells[1].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[3].Cells[1].Value = null;

            Nivel4.Rows[6].Cells[1].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[6].Cells[1].Value = null;
            Nivel4.Rows[8].Cells[1].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[8].Cells[1].Value = null;
            Nivel4.Rows[0].Cells[2].Style.BackColor = Color.DarkBlue;


            Nivel4.Rows[0].Cells[2].Value = null;
            Nivel4.Rows[2].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[2].Value = null;
            Nivel4.Rows[3].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[2].Value = null;
            Nivel4.Rows[4].Cells[2].Value = null;
            Nivel4.Rows[4].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[5].Cells[2].Value = null;
            Nivel4.Rows[5].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[6].Cells[2].Value = null;
            Nivel4.Rows[6].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[7].Cells[2].Value = null;
            Nivel4.Rows[7].Cells[2].Style.BackColor = Color.DarkBlue;


            Nivel4.Rows[8].Cells[2].Value = null;
            Nivel4.Rows[8].Cells[2].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[3].Value = null;
            Nivel4.Rows[1].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[3].Value = null;
            Nivel4.Rows[2].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[3].Value = null;
            Nivel4.Rows[3].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[3].Value = null;
            Nivel4.Rows[4].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[5].Cells[3].Value = null;
            Nivel4.Rows[5].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[6].Cells[3].Value = null;
            Nivel4.Rows[6].Cells[3].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[7].Cells[3].Value = null;
            Nivel4.Rows[7].Cells[3].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[0].Cells[4].Value = null;
            Nivel4.Rows[0].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[4].Value = null;
            Nivel4.Rows[1].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[4].Value = null;
            Nivel4.Rows[3].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[4].Value = null;
            Nivel4.Rows[4].Cells[4].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[6].Cells[4].Value = null;
            Nivel4.Rows[6].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[7].Cells[4].Value = null;
            Nivel4.Rows[7].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[8].Cells[4].Value = null;
            Nivel4.Rows[8].Cells[4].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[0].Cells[5].Value = null;
            Nivel4.Rows[0].Cells[5].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[5].Value = null;
            Nivel4.Rows[1].Cells[5].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[5].Value = null;
            Nivel4.Rows[3].Cells[5].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[5].Value = null;
            Nivel4.Rows[4].Cells[5].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[7].Cells[5].Value = null;
            Nivel4.Rows[7].Cells[5].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[8].Cells[5].Value = null;
            Nivel4.Rows[8].Cells[5].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[0].Cells[6].Value = null;
            Nivel4.Rows[0].Cells[6].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[6].Value = null;
            Nivel4.Rows[2].Cells[6].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[6].Value = null;
            Nivel4.Rows[3].Cells[6].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[5].Cells[6].Value = null;
            Nivel4.Rows[5].Cells[6].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[6].Cells[6].Value = null;
            Nivel4.Rows[6].Cells[6].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[7].Cells[6].Value = null;
            Nivel4.Rows[7].Cells[6].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[8].Cells[6].Value = null;
            Nivel4.Rows[8].Cells[6].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[0].Cells[7].Value = null;
            Nivel4.Rows[0].Cells[7].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[7].Value = null;
            Nivel4.Rows[1].Cells[7].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[7].Value = null;
            Nivel4.Rows[3].Cells[7].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[4].Cells[7].Value = null;
            Nivel4.Rows[4].Cells[7].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[5].Cells[7].Value = null;
            Nivel4.Rows[5].Cells[7].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[6].Cells[7].Value = null;
            Nivel4.Rows[6].Cells[7].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[8].Cells[7].Value = null;
            Nivel4.Rows[8].Cells[7].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[0].Cells[8].Value = null;
            Nivel4.Rows[0].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[1].Cells[8].Value = null;
            Nivel4.Rows[1].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[2].Cells[8].Value = null;
            Nivel4.Rows[2].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[3].Cells[8].Value = null;
            Nivel4.Rows[3].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[5].Cells[8].Value = null;
            Nivel4.Rows[5].Cells[8].Style.BackColor = Color.DarkBlue;

            Nivel4.Rows[6].Cells[8].Value = null;
            Nivel4.Rows[6].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[7].Cells[8].Value = null;
            Nivel4.Rows[7].Cells[8].Style.BackColor = Color.DarkBlue;
            Nivel4.Rows[8].Cells[8].Value = null;
            Nivel4.Rows[8].Cells[8].Style.BackColor = Color.DarkBlue;



        }



    }

}



