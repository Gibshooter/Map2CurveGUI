namespace Map2CurveGUI
{
	partial class Result
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
			this.FormResult_pbox = new System.Windows.Forms.PictureBox();
			this.FormResult_tbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.FormResult_pbox)).BeginInit();
			this.SuspendLayout();
			// 
			// FormResult_pbox
			// 
			this.FormResult_pbox.Image = global::Map2CurveGUI.Properties.Resources.Sign_Success;
			this.FormResult_pbox.Location = new System.Drawing.Point(12, 12);
			this.FormResult_pbox.Name = "FormResult_pbox";
			this.FormResult_pbox.Size = new System.Drawing.Size(120, 120);
			this.FormResult_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.FormResult_pbox.TabIndex = 1;
			this.FormResult_pbox.TabStop = false;
			// 
			// FormResult_tbox
			// 
			this.FormResult_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FormResult_tbox.Location = new System.Drawing.Point(152, 12);
			this.FormResult_tbox.Multiline = true;
			this.FormResult_tbox.Name = "FormResult_tbox";
			this.FormResult_tbox.ReadOnly = true;
			this.FormResult_tbox.Size = new System.Drawing.Size(320, 75);
			this.FormResult_tbox.TabIndex = 2;
			this.FormResult_tbox.Text = "Processing Result Text";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(152, 93);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(320, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 146);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.FormResult_tbox);
			this.Controls.Add(this.FormResult_pbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Result";
			this.Text = "Map2Curve Result";
			((System.ComponentModel.ISupportInitialize)(this.FormResult_pbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox FormResult_pbox;
		private System.Windows.Forms.TextBox FormResult_tbox;
		private System.Windows.Forms.Button button1;
	}
}