using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchAreaToImage
{
    public partial class Form2 : Form
    {
      /*  protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }*/

        Point startPos;      // mouse-down position
        Point currentPos;    // current mouse position
        bool drawing;

        public Form2()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.Turquoise;
            this.Opacity = 0.75;
            this.Cursor = Cursors.Cross;
            this.MouseDown += Form2_MouseDown;
            this.MouseMove += Form2_MouseMove;
            this.MouseUp += Form2_MouseUp;
            this.Paint += Form2_Paint;
            this.KeyDown += Form2_KeyDown;
            this.DoubleBuffered = true;
            this.TransparencyKey = Color.Turquoise;

        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing) this.Invalidate();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (drawing) e.Graphics.DrawRectangle(Pens.Red, GetRectangle());

        }
    }
}

