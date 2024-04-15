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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        public int W
        {
            get
            {
                string text = tbWidth.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = tbHeight.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public string FileName
        {
            get
            {
                return tbFileName.Text;
            }
        }

        bool _canceled = true;
        public bool Canceled
        {
            get
            {
                return _canceled;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _canceled = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
