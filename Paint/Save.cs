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
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }
        Image image;
        bool _saved = false;
        public bool Saved { get { return _saved; } }

        public Save(string fileName, Image img)
        {
            InitializeComponent();
            textBox2.Text = fileName;
            image = img;
        }


        public void save1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void okBut2_Click(object sender, EventArgs e)
        {

            image.Save(textBox1.Text + textBox2.Text);
            _saved = true;
            Close();
        }

        private void canBut3_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
