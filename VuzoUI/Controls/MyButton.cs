/*
 * Created by SharpDevelop.
 * Date: 17.10.2013
 * Time: 13:33
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VuzoUI.Controls
{
	/// <summary>
	/// Description of Button.
	/// </summary>
	public class MyButton : Button
	{
		bool _mouseOver = false;
		bool _mouseDown = false;
		
		internal Color _bgGradTop;
		internal Color _bgGradBot;
		internal Color _textColor;
		internal Color _outLine;
		internal float _rounded;
		
		bool _inOnPaint = false;
		
		[Browsable(true), Category("Colors")]
		[DefaultValue(typeof(Color), "0x94, 0xc1, 0x1f")]
		public Color BGGradTop { get { return _bgGradTop; } set { _bgGradTop = value; } }
		
		[Browsable(true), Category("Colors")]
		[DefaultValue(typeof(Color), "0xcd, 0xe2, 0x96")]
		public Color BGGradBot { get { return _bgGradBot; } set { _bgGradBot = value; } }
		
		[Browsable(true), Category("Colors")]
		[DefaultValue(typeof(Color), "0x40, 0x57, 0x04")]
		public Color TextColor { get { return _textColor; } set { _textColor = value; } }
		
		[Browsable(true), Category("Colors")]
		[DefaultValue(typeof(Color), "0x79, 0x94, 0x29")]
		public Color OutLine { get { return _outLine; } set { _outLine = value; } }
		
		[Browsable(true), Category("Colors")]
		[DefaultValue(typeof(float), "5.0f")]
		public float Rounded { get { return _rounded; } set { _rounded = value; } }
		
		public MyButton()
		{
			_bgGradTop = Color.FromArgb(0x94, 0xc1, 0x1f);
			_bgGradBot = Color.FromArgb(0xcd, 0xe2, 0x96);
			_textColor = Color.FromArgb(0x40, 0x57, 0x04);
			_outLine = Color.FromArgb(0x79, 0x94, 0x29);
			_rounded = 5.0f;
		}
		
		protected override void OnPaint(PaintEventArgs pevent)
		{
			// base.OnPaint(pevent);
			if (_inOnPaint)
				return;
			
			_inOnPaint = true;
			
			try
			{
				Graphics g = pevent.Graphics;
				g.Clear(this.BackColor);
				g.SmoothingMode = SmoothingMode.AntiAlias;
				
				Rectangle outSide = new Rectangle(0, 0, this.Width, this.Height);
				LinearGradientBrush linearBrush = new LinearGradientBrush(outSide, BGGradTop, BGGradBot, LinearGradientMode.Vertical);
				Pen myPen = new Pen(OutLine, 1);
				GraphicsPath path = new GraphicsPath();
				
				float wid = _rounded;
				int width = this.Width - 1;
				int height = this.Height - 1;
				
				// tl
				path.AddArc(0, 0, wid, wid, 180, 90);
				// top line
				path.AddLine(wid, 0, width - wid, 0);
				// tl
				path.AddArc(width - wid, 0, wid, wid, 270, 90);
				// br
				path.AddArc(width - wid, height - wid, wid, wid, 0, 90);
				// bottom line
				path.AddLine(wid, height, width - wid, height);
				// bl
				path.AddArc(0, height - wid, wid, wid, 90, 90);
				// left line
				path.AddLine(0, height - wid, 0, wid - wid / 2);
				
				g.FillPath(linearBrush, path);
				g.DrawPath(myPen, path);
				
				SolidBrush myBrush = new SolidBrush(TextColor);
				
				if (_mouseOver)
				{
					SolidBrush brush = new SolidBrush(Color.FromArgb(73, 0x2b, 0x3a, 0x03));
					g.FillPath(brush, path);
				}
				if (_mouseDown)
				{
					SolidBrush brush = new SolidBrush(Color.FromArgb(73, 0x2b, 0x3a, 0x03));
					g.FillPath(brush, path);
				}
				if (!this.Enabled)
				{
					SolidBrush brush = new SolidBrush(Color.FromArgb(150, 0x2b, 0x3a, 0x03));
					g.FillPath(brush, path);
				}
				
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				
				string display = this.Text;
				int amppos = display.IndexOf('&');
				if (amppos != -1)
					display = display.Remove(amppos, 1);
				
				g.DrawString(display, this.Font, myBrush, outSide, stringFormat);
			}
			catch
			{
			}
			
			_inOnPaint = false;
		}
		
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
		}
		
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			// base.OnPaintBackground(pevent);
		}
		
		protected override void OnMouseEnter(EventArgs e)
		{
			_mouseOver = true;
			base.OnMouseEnter(e);
		}
		
		protected override void OnMouseLeave(EventArgs e)
		{
			_mouseOver = false;
			base.OnMouseLeave(e);
		}
		
		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			_mouseDown = true;
			base.OnMouseDown(mevent);
		}
		
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			_mouseDown = false;
			base.OnMouseUp(mevent);
		}
	}
}
