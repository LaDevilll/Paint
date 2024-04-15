using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(2000, 1000);
        }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        int _x;
        int _y;
        bool _mouseClicked = false;
        public Color SelectedColor
        {
            get
            {
                return colorDialog1.Color;
            }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selectedBrush;

        private void button1_Click_1(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SnegBr(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBr(SelectedColor, SelectedSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBr(SelectedColor, SelectedSize);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _selectedBrush = new LastikBr(SelectedSize);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (_selectedBrush != null)
            {
                _selectedBrush.Size = trackBar1.Value;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(_selectedBrush == null)
            {
                return;
            }
            _selectedBrush.Draw (pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBlank(1000, 1000);
            Size form = new Size();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void newColorButton_Click(object sender, EventArgs e) //Выбор цвета из палитры
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button7.BackColor = colorDialog1.Color;
            }
        }























        private void label1_Click(object sender, EventArgs e)
        {

        }



        

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
