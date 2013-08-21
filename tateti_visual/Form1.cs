using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases_tateti;

namespace tateti_visual
{
    public partial class tateti_frm : Form
    {
        private int jugador_actual;
        private int ficha_actual;
        private int ficha_a_mover;

        public Juego juego; //**

        public tateti_frm()
        {
            jugador_actual = 1;
            ficha_actual = 1;
            //construye la parte gráfica
            InitializeComponent();
            Actualizar_Pantalla();
            juego = new Juego();
        }

        private void Actualizar_Pantalla()
        {
            lbl_jugador_actual.Text = jugador_actual.ToString();
            lbl_ficha_actual.Text = ficha_actual.ToString();
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
                ficha_actual=ficha_actual+1;
                if (ficha_actual==4)
                {
                    ficha_actual=0;
                }
            }
        }

        private void tateti_frm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic9.Image = tateti_visual.Properties.Resources.la_o;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            if (ficha_actual == 0)
            {
                int 
            }
            else
            {
                int posicion_elegida = 1;
                juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                Definir_Ficha_Proxima();
                Definir_Imagen(pic1);
                Alternar_Jugador();
                Actualizar_Pantalla();
            }
            
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
            int posicion_elegida = 2;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic2);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 3;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic3);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 4;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic4);
            Alternar_Jugador();
            Actualizar_Pantalla();
           
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 5;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic5);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 6;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic6);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 7;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic7);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
            
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 8;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic8);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            int posicion_elegida = 9;
            juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
            Definir_Ficha_Proxima();
            Definir_Imagen(pic9);
            Alternar_Jugador();
            Actualizar_Pantalla();
            
        }
    }
}
