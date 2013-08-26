using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases_tateti;
using System.Collections;

namespace tateti_visual
{
    public partial class tateti_frm : Form
    {
        private int jugador_actual;
        private int ficha_actual;
        private int ficha_a_mover;
        private int ficha_seleccionada;
        private Hashtable pictures;
        

        public Juego juego; //**

        public tateti_frm()
        {
            jugador_actual = 1;
            ficha_actual = 1;
            //construye la parte gráfica
            InitializeComponent();
            
            juego = new Juego();
            pictures = new Hashtable();
            pictures.Add(1, pic1);
            pictures.Add(2, pic2);
            pictures.Add(3, pic3);
            pictures.Add(4, pic4);
            pictures.Add(5, pic5);
            pictures.Add(6, pic6);
            pictures.Add(7, pic7);
            pictures.Add(8, pic8);
            pictures.Add(9, pic9);
            Actualizar_Pantalla();

        }

        private void Actualizar_Pantalla()
        {
            lbl_jugador_actual.Text = jugador_actual.ToString();
            lbl_ficha_actual.Text = ficha_actual.ToString();
            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                pic.BorderStyle = BorderStyle.None;
                if (pic.Tag.ToString() != "Fondo")
                    pic.Image = null;
                
            }
            Actualizar_Tablero();
        }
        private void Actualizar_Pantalla(PictureBox pic_seleccionada)
        {
            lbl_jugador_actual.Text = jugador_actual.ToString();
            lbl_ficha_actual.Text = ficha_actual.ToString();
            //utilizo el método OfType para obtener los picturebox que tiene
            //el formulario, para borrarles el borde que puedan tener establecido
            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                pic.BorderStyle = BorderStyle.None;
                if (pic.Tag.ToString()!="Fondo")
                    pic.Image = null;
                
            }
            pic_seleccionada.BorderStyle = BorderStyle.Fixed3D;
            Actualizar_Tablero();

        }

        private void Actualizar_Tablero()
        {
            foreach (DictionaryEntry ficha in juego.jugador1.fichas)
            {
                foreach (DictionaryEntry entrada_pic in pictures)
                {
                    if (entrada_pic.Key.ToString() == ficha.Value.ToString())
                    {
                        PictureBox imagen=(PictureBox)entrada_pic.Value;
                        imagen.Image=tateti_visual.Properties.Resources.equis;
                    }
                }

            }
            foreach (DictionaryEntry ficha in juego.jugador2.fichas)
            {
                foreach (DictionaryEntry entrada_pic in pictures)
                {
                    if (entrada_pic.Key.ToString() == ficha.Value.ToString())
                    {
                        PictureBox imagen = (PictureBox)entrada_pic.Value;
                        imagen.Image = tateti_visual.Properties.Resources.la_o;
                    }
                }
            }
        }
        private void Alternar_Jugador()
        {
            if (jugador_actual==1)
                jugador_actual=2;
            else
                jugador_actual=1;
        }
        private void Definir_Ficha_Proxima()
        {
            if (jugador_actual==2)
            {
                if (ficha_actual > 0)
                {
                    ficha_actual = ficha_actual + 1;
                    if (ficha_actual == 4)
                    {
                        ficha_actual = 0;
                    }
                }
            }
        }





        private void Movimiento(int posicion_elegida, PictureBox pic)
        {
            int ganador=juego.ComprobarGanador();
            if (ganador==0)
            {
                if (ficha_actual == 0)
                {
                    if (ficha_seleccionada == 0)
                    {
                        ficha_seleccionada = juego.SeleccionarFicha(jugador_actual, posicion_elegida);
                        if (ficha_seleccionada == 0)
                        {
                            MessageBox.Show("Error, no ha seleccionado una de sus fichas");
                        }
                        else
                        {
                            Actualizar_Pantalla(pic);
                        }
                    }
                    else
                    {
                        if (!juego.ComprobarPosicionVacia(posicion_elegida))
                        {
                            int otra_ficha_seleccionada = juego.SeleccionarFicha(jugador_actual, posicion_elegida);
                            if (otra_ficha_seleccionada == 0)
                            {
                                MessageBox.Show("Error, no ha seleccionado una de sus fichas");
                            }
                            else
                            {
                                ficha_seleccionada = otra_ficha_seleccionada;
                                Actualizar_Pantalla(pic);
                            }
                        }
                        else
                        {
                            if (juego.ComprobarMovimientoValido(posicion_elegida, jugador_actual, ficha_seleccionada))
                            {
                                if (juego.ComprobarPosicionVacia(posicion_elegida))
                                {
                                    juego.Jugar(jugador_actual, ficha_seleccionada, posicion_elegida);
                                    Definir_Ficha_Proxima();
                                    //Definir_Imagen(pic);
                                    Alternar_Jugador();
                                    ficha_seleccionada = 0;
                                    Actualizar_Pantalla();
                                }
                                else
                                {

                                    MessageBox.Show("Debes seleccionar un lugar vacío");
                                }
                            }
                            else
                                MessageBox.Show("Has intentado un movimiento no válido");
                        }

                    }
                }
                else
                {
                    if (juego.ComprobarPosicionVacia(posicion_elegida))
                    {
                        juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                        Definir_Ficha_Proxima();
                        //Definir_Imagen(pic);
                        Alternar_Jugador();
                        Actualizar_Pantalla();
                    }
                    else
                        MessageBox.Show("Debes seleccionar un lugar vacío");
                }
                ganador = juego.ComprobarGanador();
                if (ganador != 0)
                    MessageBox.Show("Ha ganado el jugador N°" + ganador.ToString());
            }
            else
            {
                MessageBox.Show("Ha ganado el jugador N°" + ganador.ToString());
            }
            

        }
        private void pic1_Click(object sender, EventArgs e)
        {
            Movimiento(1, pic1);
            
        }
        private void Definir_Imagen(PictureBox pic)
        {
            if (jugador_actual == 1)
                pic.Image = tateti_visual.Properties.Resources.equis;
            else
                pic.Image = tateti_visual.Properties.Resources.la_o;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Movimiento(2, pic2);
            
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Movimiento(3, pic3);
            
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            Movimiento(4, pic4);
           
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            Movimiento(5, pic5);
            
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            Movimiento(6, pic6);
            
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            Movimiento(7, pic7);
            
            
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            Movimiento(8, pic8);
            
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            Movimiento(9, pic9);
            
        }




    }
}
