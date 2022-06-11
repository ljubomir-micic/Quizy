using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy
{
    public class Divider : Label
    {
        void Devider()
        {
            this.AutoSize = false;
            this.Height = 2;
            this.Width = 200;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);
            this.AutoSize = false;
            this.Height = 2;
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), new Size(Width, 2)));
        }
    }
}
