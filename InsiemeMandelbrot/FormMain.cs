using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsiemeMandelbrot
{
    public partial class FormMain : Form
    {
        const int MAX = 1000;
        public FormMain()
        {
            InitializeComponent();
        }

        int Gpenna, Npixel, n34, n12, n14;//3/4 di Npixel,2/4 di Npixel ,1/4 di Npixel; 
        Thread[] t = new Thread[8];
        Bitmap[] b = new Bitmap[8];

        private void btnRidisegna_Click(object sender, EventArgs e)
        {
            AggiornaGrafica(null, null);
        }

        private void btnDisegna_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                b[i] = null;

            if (rdScarsa.Checked == true)
                Npixel = 80;
            else if (rdBuona.Checked == true)
                Npixel = 200;
            else
                Npixel = 400;

            Gpenna = 400 / Npixel;

            //Mi salvo le unità perchè le uso spesso in seguito
            n14 = Npixel >> 2;
            n12 = Npixel >> 1;
            n34 = ((Npixel << 1) + Npixel) >> 2;//moltiplico per 2, aggiungo 1 unità (moltiplicato per 3), divido per 4

            btnRidisegna.Visible = true;
            SmistaTread(); //Calcolo della frattale
        }

        void SmistaTread()
        {
            for (int i = 0; i < 8; i++)
                t[i] = null;

            t[0] = new Thread(T1);
            t[1] = new Thread(T2);
            t[2] = new Thread(T3);
            t[3] = new Thread(T4);
            t[4] = new Thread(T5);
            t[5] = new Thread(T6);
            t[6] = new Thread(T7);
            t[7] = new Thread(T8);

            for (int i = 0; i < 8; i++)
                t[i].Start();

            for (int i = 0; i < 8; i++)
                t[i].Join(Timeout.Infinite);

            for (int i = 0; i < 8; i++)
                t[i] = null;

            AggiornaGrafica(null, null);
            return;
        }

        private void AggiornaGrafica(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                if (b[i] != null)
                    pnl.CreateGraphics().DrawImage(b[i], 0, 0);
        }

        void Procedimento(int i, ref Graphics graph)
        {
            int x, y, count;
            Complex c, z;
            Color colore;

            for (int r = -(Npixel << 1); r < Npixel; r++)
            {
                //Calcolo Frattale
                //Insieme di Mandelbrot
                //Verisone originale
                
                z = new Complex(0, 0);
                c = new Complex((double)r / (double)Npixel, (double)i / (double)Npixel);
                count = 0;
                while (count < MAX && z.Magnitude <= 2)
                {
                    z = Complex.Pow(z, 2);
                    z += c;
                    ++count;
                }
                //Ho calcolato, ora decido il colore
                if (z.Magnitude <= 2)
                    colore = Color.FromArgb(0, 0, 0);
                else
                {
                    if (count <= 3)
                        colore = Color.FromArgb(0, 0, 120);
                    else if (count <= 6)
                        colore = Color.FromArgb(0, 0, 200);
                    else if (count <= 10)
                        colore = Color.FromArgb(0, 0, 255);
                    else if (count <= 14)
                        colore = Color.FromArgb(0, 180, 180);
                    else if (count <= 20)
                        colore = Color.FromArgb(0, 120, 0);
                    else if (count <= 50)
                        colore = Color.FromArgb(255 ,255, 0);
                    else if(count <= 100)
                        colore = Color.FromArgb(255, 102, 0);
                    else 
                        colore = Color.FromArgb(255, 0, 0);                    
                }

                //Calcolo la posizione per disegnare
                y = (Npixel + 1 - i) * Gpenna; 
                x = (r + (Npixel << 1)) * Gpenna;

                //Disegno
                graph.DrawLine(new Pen(colore, Gpenna), new Point(x, y), new Point(x + Gpenna + 1, y));
            }
            return;
        }

        //*****************************************************************

        void T1()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel; i > Npixel - n14; i--)
                Procedimento(i, ref g);
            this.b[0] = b;
            b = null;
            return;
        }
        void T2()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n14; i > Npixel - n12; i--)
                Procedimento(i, ref g);
            this.b[1] = b;
            b = null;
            return;
        }
        void T3()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n12; i > Npixel - n34; i--)
                Procedimento(i, ref g);
            this.b[2] = b;
            b = null;
            return;
        }
        void T4()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = Npixel - n34; i > 0; i--)
                Procedimento(i, ref g);
            this.b[3] = b;
            b = null;
            return;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        void T5()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = 0; i > -n14; i--)
                Procedimento(i, ref g);
            this.b[4] = b;
            b = null;
            return;
        }
        void T6()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -14; i > -n12; i--)
                Procedimento(i, ref g);
            this.b[5] = b;
            b = null;
            return;
        }
        void T7()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -n12; i > -n34; i--)
                Procedimento(i, ref g);
            this.b[6] = b;
            b = null;
            return;
        }
        void T8()
        {
            Bitmap b = new Bitmap(pnl.Width, pnl.Height);
            Graphics g = Graphics.FromImage(b);
            for (int i = -n34; i > -Npixel; i--)
                Procedimento(i, ref g);
            this.b[7] = b;
            b = null;
            return;
        }
    }
}

