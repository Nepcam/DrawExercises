using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Graphics canvas = pictureBox.CreateGraphics();
            Color col = Color.FromArgb(2, 60, 254);
            Pen outlinePen = new Pen(col, 5);
            canvas.DrawEllipse(outlinePen, 100, 100, 200, 200);
        }
    }
}
