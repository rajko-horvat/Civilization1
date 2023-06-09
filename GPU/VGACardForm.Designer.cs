﻿namespace Disassembler
{
	partial class VGACardForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VGACardForm));
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.cmdPause = new System.Windows.Forms.ToolStripButton();
			this.cmdRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.lblPlane = new System.Windows.Forms.ToolStripLabel();
			this.tsPlanes = new System.Windows.Forms.ToolStripSplitButton();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Enabled = true;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// tsMain
			// 
			this.tsMain.BackColor = System.Drawing.SystemColors.Control;
			this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdPause,
            this.cmdRun,
            this.toolStripSeparator1,
            this.lblPlane,
            this.tsPlanes});
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.tsMain.Size = new System.Drawing.Size(600, 27);
			this.tsMain.TabIndex = 0;
			this.tsMain.Text = "toolStrip1";
			// 
			// cmdPause
			// 
			this.cmdPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdPause.Image = ((System.Drawing.Image)(resources.GetObject("cmdPause.Image")));
			this.cmdPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdPause.Name = "cmdPause";
			this.cmdPause.Size = new System.Drawing.Size(29, 24);
			this.cmdPause.Text = "Pause";
			// 
			// cmdRun
			// 
			this.cmdRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdRun.Image = ((System.Drawing.Image)(resources.GetObject("cmdRun.Image")));
			this.cmdRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdRun.Name = "cmdRun";
			this.cmdRun.Size = new System.Drawing.Size(29, 24);
			this.cmdRun.Text = "Run";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// lblPlane
			// 
			this.lblPlane.BackColor = System.Drawing.SystemColors.Control;
			this.lblPlane.Name = "lblPlane";
			this.lblPlane.Size = new System.Drawing.Size(54, 28);
			this.lblPlane.Text = "Planes:";
			// 
			// tsPlanes
			// 
			this.tsPlanes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPlanes.Image = ((System.Drawing.Image)(resources.GetObject("tsPlanes.Image")));
			this.tsPlanes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPlanes.Name = "tsPlanes";
			this.tsPlanes.Size = new System.Drawing.Size(39, 24);
			this.tsPlanes.Text = "Plane list";
			// 
			// VGACardForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.ControlBox = false;
			this.Controls.Add(this.tsMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "VGACardForm";
			this.ShowIcon = false;
			this.Text = "VGA display";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.VGACardForm_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VGACardForm_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VGACardForm_KeyPress);
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer tmrRefresh;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton cmdPause;
		private System.Windows.Forms.ToolStripButton cmdRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel lblPlane;
		private System.Windows.Forms.ToolStripSplitButton tsPlanes;
	}
}