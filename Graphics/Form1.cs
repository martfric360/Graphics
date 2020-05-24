using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphics
{
    public partial class Form1 : Form
    {

     
        public Form1()
        {
            InitializeComponent();
            
          
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g;

            g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 29);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            drawPen.Color = Color.White;
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 125, 75, 165, 165);
            g.DrawEllipse(drawPen, 163, 110, 90, 90);
            Font drawFont = new Font("Arial", 32, FontStyle.Bold);
            g.DrawString("TARGET", drawFont, drawBrush, 120, 240);

        }
    }
}
