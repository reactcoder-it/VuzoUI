/*
 * Created by SharpDevelop.
 * User: Vadim Pashaev <vmp@live.ru>
 * Date: 17.10.2013
 * Time: 14:11
 */
namespace VuzoUIDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.myButton1 = new VuzoUI.Controls.MyButton();
			this.myButton2 = new VuzoUI.Controls.MyButton();
			this.myButton3 = new VuzoUI.Controls.MyButton();
			this.SuspendLayout();
			// 
			// myButton1
			// 
			this.myButton1.Location = new System.Drawing.Point(16, 16);
			this.myButton1.Name = "myButton1";
			this.myButton1.Size = new System.Drawing.Size(75, 23);
			this.myButton1.TabIndex = 0;
			this.myButton1.Text = "myButton1";
			this.myButton1.UseVisualStyleBackColor = true;
			// 
			// myButton2
			// 
			this.myButton2.Location = new System.Drawing.Point(104, 16);
			this.myButton2.Name = "myButton2";
			this.myButton2.Size = new System.Drawing.Size(75, 23);
			this.myButton2.TabIndex = 1;
			this.myButton2.Text = "myButton2";
			this.myButton2.UseVisualStyleBackColor = true;
			// 
			// myButton3
			// 
			this.myButton3.Location = new System.Drawing.Point(192, 16);
			this.myButton3.Name = "myButton3";
			this.myButton3.Size = new System.Drawing.Size(75, 23);
			this.myButton3.TabIndex = 2;
			this.myButton3.Text = "myButton3";
			this.myButton3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 344);
			this.Controls.Add(this.myButton3);
			this.Controls.Add(this.myButton2);
			this.Controls.Add(this.myButton1);
			this.Name = "MainForm";
			this.Text = "VuzoUIDemo";
			this.ResumeLayout(false);
		}
		private VuzoUI.Controls.MyButton myButton3;
		private VuzoUI.Controls.MyButton myButton2;
		private VuzoUI.Controls.MyButton myButton1;
	}
}
