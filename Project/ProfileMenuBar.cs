/*
 * Created by SharpDevelop.
 * User: ljubo
 * Date: 02.06.2022.
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Quizy
{
	/// <summary>
	/// Description of ProfileMenuBar.
	/// </summary>
	public class ProfileMenuBar : ContextMenuStrip
	{
		protected override void OnPaint(PaintEventArgs e)
		{
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent.BackColor);
            
            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, this.Width, 200 * this.Items.Count));
            
            for(int i = 0; i < this.Items.Count; i++) {
            	e.Graphics.DrawString(this.Items[i].Text, new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point), new SolidBrush(Color.Black), 20, 90 + 200 * i);
            }
		}
	}
}
