using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Resources;
using System.IO;

namespace Olho_De_Deus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            velocidadeSmooth.Text = "0";
            anguloMaximo.Text = "0";
        }
        bool podeMover = false;
        Point localForm;


        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarSmooth.Minimum = 0;
            trackBarSmooth.Maximum = 50;

            trackbarAnguloMaximo.Minimum = 0;
            trackbarAnguloMaximo.Maximum = 100;


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                this.Hide();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void border_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                podeMover = true;
                localForm = e.Location;
            }
        }

        private void border_top_MouseUp(object sender, MouseEventArgs e)
        {
            podeMover = false;
        }

        private void border_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (podeMover == true)
            {
                int x = localForm.X - e.Location.X;
                int y = localForm.Y - e.Location.Y;
                Location = new Point(Location.X -x, Location.Y - y);
            }
        }
        //protected override  void OnPaint(PaintEventArgs e)
        //{
        //    Point[] pontos = {
               
        //        new Point(50,0),
        //         new Point(50,0),
        //        new Point(640,0),
        //        new Point(620,30),
        //        new Point(430,30),
        //        new Point(70,30),
        //        new Point(60,15)};

        //    GraphicsPath poly = new GraphicsPath();
        //    poly.AddPolygon(pontos);
        //    border_top.Region = new Region(poly);
        //    Pen borda = new Pen(Color.White, 5);
        //    e.Graphics.DrawPolygon(borda, pontos);

        //}


        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void espBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void velocidadeSmooth_Click(object sender, EventArgs e)
        {

        }

        private void trackBarSmooth_Scroll(object sender, ScrollEventArgs e)
        {
            velocidadeSmooth.Text = trackBarSmooth.Value.ToString();
            
        }

        private void trackbarAnguloMaximo_Scroll(object sender, ScrollEventArgs e)
        {
            anguloMaximo.Text = trackbarAnguloMaximo.Value.ToString();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
