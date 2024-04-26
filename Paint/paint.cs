using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class paint : Form
    {
        public paint()
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
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
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
            set
            {
                colorDialog1.Color = value;
            }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selectedBrush;
        private void Quad_Click_1(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void Sneg_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SnegBr(SelectedColor, SelectedSize);
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBr(SelectedColor, SelectedSize);
        }

        private void Spray_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBr(SelectedColor, SelectedSize);
        }

        private void Lastik_Click(object sender, EventArgs e)
        {
            _selectedBrush = new LastikBr(SelectedSize);
        }

        private void BrushSize_Scroll(object sender, EventArgs e)
        {

            if (_selectedBrush != null)
            {
                _selectedBrush.Size = trackBar1.Value;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
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
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PalitraButton.BackColor = colorDialog1.Color;
            }
            Button button = (Button)sender;
            SelectedColor = button.BackColor;
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = SelectedColor;
            }
        }

        private void RedColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SelectedColor = button.BackColor;
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = SelectedColor;
            }

        }

        private void BlueColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SelectedColor = button.BackColor;
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = SelectedColor;
            }
        }

        private void GreenColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SelectedColor = button.BackColor;
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = SelectedColor;
            }
        }

        private void PurpleColor1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SelectedColor = button.BackColor;
            if (_selectedBrush != null)
            {
                _selectedBrush.BrushColor = SelectedColor;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size sizeForm = new Size();
            DialogResult result = sizeForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //если нажали ОК
                int width = sizeForm.W;
                int height = sizeForm.H;
                string fileName = sizeForm.FileName;
                CreateBlank(width, height);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

      

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save SaveForm = new Save();
            DialogResult result = SaveForm.ShowDialog();
        }








        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
