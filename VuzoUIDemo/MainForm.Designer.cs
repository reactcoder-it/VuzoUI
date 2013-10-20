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
			this.myButton4 = new VuzoUI.Controls.MyButton();
			this.myButton5 = new VuzoUI.Controls.MyButton();
			this.myButton6 = new VuzoUI.Controls.MyButton();
			this.myButton7 = new VuzoUI.Controls.MyButton();
			this.myButton8 = new VuzoUI.Controls.MyButton();
			this.myButton9 = new VuzoUI.Controls.MyButton();
			this.SuspendLayout();
			// 
			// myButton1
			// 
			this.myButton1.Location = new System.Drawing.Point(16, 16);
			this.myButton1.Name = "myButton1";
			this.myButton1.Rounded = 7F;
			this.myButton1.Size = new System.Drawing.Size(75, 23);
			this.myButton1.TabIndex = 0;
			this.myButton1.Text = "myButton1";
			this.myButton1.UseVisualStyleBackColor = true;
			// 
			// myButton2
			// 
			this.myButton2.Location = new System.Drawing.Point(104, 16);
			this.myButton2.Name = "myButton2";
			this.myButton2.Rounded = 7F;
			this.myButton2.Size = new System.Drawing.Size(75, 23);
			this.myButton2.TabIndex = 1;
			this.myButton2.Text = "myButton2";
			this.myButton2.UseVisualStyleBackColor = true;
			// 
			// myButton3
			// 
			this.myButton3.Location = new System.Drawing.Point(192, 16);
			this.myButton3.Name = "myButton3";
			this.myButton3.Rounded = 7F;
			this.myButton3.Size = new System.Drawing.Size(75, 23);
			this.myButton3.TabIndex = 2;
			this.myButton3.Text = "myButton3";
			this.myButton3.UseVisualStyleBackColor = true;
			// 
			// myButton4
			// 
			this.myButton4.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
			this.myButton4.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.myButton4.Location = new System.Drawing.Point(192, 48);
			this.myButton4.Name = "myButton4";
			this.myButton4.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton4.Rounded = 7F;
			this.myButton4.Size = new System.Drawing.Size(75, 23);
			this.myButton4.TabIndex = 5;
			this.myButton4.Text = "myButton4";
			this.myButton4.TextColor = System.Drawing.Color.Black;
			this.myButton4.UseVisualStyleBackColor = true;
			// 
			// myButton5
			// 
			this.myButton5.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
			this.myButton5.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.myButton5.Location = new System.Drawing.Point(104, 48);
			this.myButton5.Name = "myButton5";
			this.myButton5.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton5.Rounded = 7F;
			this.myButton5.Size = new System.Drawing.Size(75, 23);
			this.myButton5.TabIndex = 4;
			this.myButton5.Text = "myButton5";
			this.myButton5.TextColor = System.Drawing.Color.Black;
			this.myButton5.UseVisualStyleBackColor = true;
			// 
			// myButton6
			// 
			this.myButton6.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
			this.myButton6.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.myButton6.Location = new System.Drawing.Point(16, 48);
			this.myButton6.Name = "myButton6";
			this.myButton6.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton6.Rounded = 7F;
			this.myButton6.Size = new System.Drawing.Size(75, 23);
			this.myButton6.TabIndex = 3;
			this.myButton6.Text = "myButton6";
			this.myButton6.TextColor = System.Drawing.Color.Black;
			this.myButton6.UseVisualStyleBackColor = true;
			// 
			// myButton7
			// 
			this.myButton7.BGGradBot = System.Drawing.Color.CornflowerBlue;
			this.myButton7.BGGradTop = System.Drawing.Color.LightSteelBlue;
			this.myButton7.Enabled = false;
			this.myButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.myButton7.Location = new System.Drawing.Point(488, 296);
			this.myButton7.Name = "myButton7";
			this.myButton7.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton7.Rounded = 7F;
			this.myButton7.Size = new System.Drawing.Size(75, 32);
			this.myButton7.TabIndex = 8;
			this.myButton7.Text = "Сохранить";
			this.myButton7.TextColor = System.Drawing.Color.Black;
			this.myButton7.UseVisualStyleBackColor = true;
			// 
			// myButton8
			// 
			this.myButton8.BGGradBot = System.Drawing.Color.CornflowerBlue;
			this.myButton8.BGGradTop = System.Drawing.Color.LightSteelBlue;
			this.myButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.myButton8.Location = new System.Drawing.Point(400, 296);
			this.myButton8.Name = "myButton8";
			this.myButton8.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton8.Rounded = 7F;
			this.myButton8.Size = new System.Drawing.Size(75, 32);
			this.myButton8.TabIndex = 7;
			this.myButton8.Text = "Отмена";
			this.myButton8.TextColor = System.Drawing.Color.Black;
			this.myButton8.UseVisualStyleBackColor = true;
			// 
			// myButton9
			// 
			this.myButton9.BGGradBot = System.Drawing.Color.CornflowerBlue;
			this.myButton9.BGGradTop = System.Drawing.Color.LightSteelBlue;
			this.myButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.myButton9.Location = new System.Drawing.Point(312, 296);
			this.myButton9.Name = "myButton9";
			this.myButton9.OutLine = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
			this.myButton9.Rounded = 7F;
			this.myButton9.Size = new System.Drawing.Size(75, 32);
			this.myButton9.TabIndex = 6;
			this.myButton9.Text = "OK";
			this.myButton9.TextColor = System.Drawing.Color.Black;
			this.myButton9.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 344);
			this.Controls.Add(this.myButton7);
			this.Controls.Add(this.myButton8);
			this.Controls.Add(this.myButton9);
			this.Controls.Add(this.myButton4);
			this.Controls.Add(this.myButton5);
			this.Controls.Add(this.myButton6);
			this.Controls.Add(this.myButton3);
			this.Controls.Add(this.myButton2);
			this.Controls.Add(this.myButton1);
			this.Name = "MainForm";
			this.Text = "VuzoUIDemo";
			this.ResumeLayout(false);
		}
		private VuzoUI.Controls.MyButton myButton9;
		private VuzoUI.Controls.MyButton myButton8;
		private VuzoUI.Controls.MyButton myButton7;
		private VuzoUI.Controls.MyButton myButton6;
		private VuzoUI.Controls.MyButton myButton5;
		private VuzoUI.Controls.MyButton myButton4;
		private VuzoUI.Controls.MyButton myButton3;
		private VuzoUI.Controls.MyButton myButton2;
		private VuzoUI.Controls.MyButton myButton1;
	}
}
