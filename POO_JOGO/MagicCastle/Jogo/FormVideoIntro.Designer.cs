﻿/*
 * Created by SharpDevelop.
 * User: Hugo
 * Date: 30/09/2022
 * Time: 08:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Jogo
{
	partial class FormVideoIntro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.WebBrowser wbVideo;
		private System.Windows.Forms.Button button1;
		
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
			this.wbVideo = new System.Windows.Forms.WebBrowser();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// wbVideo
			// 
			this.wbVideo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbVideo.Location = new System.Drawing.Point(0, 0);
			this.wbVideo.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbVideo.Name = "wbVideo";
			this.wbVideo.ScrollBarsEnabled = false;
			this.wbVideo.Size = new System.Drawing.Size(987, 544);
			this.wbVideo.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(883, 487);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 45);
			this.button1.TabIndex = 3;
			this.button1.Text = ">>";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormVideoIntro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 544);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.wbVideo);
			this.Name = "FormVideoIntro";
			this.Text = "FormVideoIntro";
			this.Load += new System.EventHandler(this.FormVideoIntroLoad);
			this.ResumeLayout(false);

		}
	}
}
