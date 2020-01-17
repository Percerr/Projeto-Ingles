﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Engleasy
{
    public class Enemy
    {
        public PictureBox pb, grave;
        public Label nome;
        public int lado = 0, posy = 0 , posx = 0, posyrnd=0, posxrnd=0;
        public bool criado = false;
        Random rnd = new Random();

        public string senha ="sword";

        public Enemy()
        {  /*CIMA
            posy = rnd.Next(0, 900);
            posx = rnd.Next(0);
            */

            /*ESQUERDA
            posy = rnd.Next(0);
            posx = rnd.Next(900);
            */

            /*baixo
            posy = rnd.Next(0, 900);
            posx = rnd.Next(590, 590);
            */

            /*direita
            posy = rnd.Next(880,880);
            posx = rnd.Next(0,590);
            */
            lado = rnd.Next(1, 5);
            if (lado == 1)
            {
                posy = rnd.Next(0, 900);
                posx = rnd.Next(0);
            }
            if (lado == 2)
            {
                posy = rnd.Next(0);
                posx = rnd.Next(900);
            }
            if (lado == 3)
            {
                posy = rnd.Next(0, 900);
                posx = rnd.Next(590, 590);
            }
            if (lado == 4)
            {
                posy = rnd.Next(880, 880);
                posx = rnd.Next(0, 590);
            }


            pb = new PictureBox();
            pb.BackColor = Color.Transparent;
            pb.Location = new Point(posy, posx);
            pb.Size = new Size(32, 32);
            pb.Image = Properties.Resources.solcima;

            grave = new PictureBox();
            grave.BackColor = Color.Transparent;
            grave.Size = new Size(32, 32);
            grave.Image = Properties.Resources.grave;

            nome = new Label();
            nome.AutoSize = true;
            nome.Location = new Point(posy, posx);
            nome.Size = new Size(15, 15);
            nome.Text = "Teste";
        }
       // public doEffect(int x, int y)
        //{
          
        //}return 

        
        
    }



}
