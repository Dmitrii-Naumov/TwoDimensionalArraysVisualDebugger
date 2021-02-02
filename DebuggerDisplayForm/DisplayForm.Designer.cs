namespace TwoDimensionalArrayVisualizer
{
	partial class DisplayForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(12, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(683, 429);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Element:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Value:";
			// 
			// ValueLabel
			// 
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(78, 30);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ValueLabel.Size = new System.Drawing.Size(0, 16);
			this.ValueLabel.TabIndex = 3;
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(78, 9);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(0, 16);
			this.AddressLabel.TabIndex = 4;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(405, 13);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(339, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Scale:";
			// 
			// DisplayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 490);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.AddressLabel);
			this.Controls.Add(this.ValueLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "DisplayForm";
			this.Text = "DisplayForm";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ValueLabel;
		private System.Windows.Forms.Label AddressLabel;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
	}
}