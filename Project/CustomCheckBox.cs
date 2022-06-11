/*
 * Created by SharpDevelop.
 * User: ucenik
 * Date: 6/1/2022
 * Time: 11:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Quizy
{
	public class CustomCheckBox : CheckBox
	{
		private Color color1 = Colors.accent[0];

        public Color onChecked {
			get {
				return color1;
			}
			set {
				color1 = value;
				BackColor = value;
				Invalidate();
			}
		}
		
		protected override void OnPaint(PaintEventArgs pevent)
		{
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

			if(this.Checked) {
				pevent.Graphics.FillEllipse(new SolidBrush(this.onChecked), new Rectangle(0, this.Height / 2 - 5, 10, 10));
            } else {
				pevent.Graphics.FillEllipse(new SolidBrush(this.onChecked), new Rectangle(0, this.Height / 2 - 5, 10, 10));
            	pevent.Graphics.FillEllipse(new SolidBrush(Color.White), new Rectangle(2, this.Height / 2 - 5 + 2, 10 - 2, 10 - 2));
			}

			pevent.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black), new PointF(13, this.Height / 2 - 8));
		}
	}
}
