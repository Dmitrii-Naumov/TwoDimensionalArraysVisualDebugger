using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDimensionalArrayVisualizer
{
	public partial class DisplayForm : Form
	{
		public int PictureScale = 5;
		public double[,] ArrayToShow;
		double MaxValue;
		double MinValue;
		public DisplayForm()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			var pos = pictureBox1.PointToClient(Cursor.Position);
			int x = pos.X / PictureScale;
			int y = pos.Y / PictureScale;
			if (x >= 0 && x < ArrayToShow.GetLength(0) && y >= 0 && y < ArrayToShow.GetLength(1))
			{
				ValueLabel.Text = ArrayToShow[x, y].ToString();
				AddressLabel.Text = $"[{x}, {y}]";
			}
			else
			{
				ValueLabel.Text = "";
				AddressLabel.Text = "";
			}
		}

		private void DisplayForm_Paint(object sender, PaintEventArgs e)
		{
			MaxValue = ArrayToShow[0, 0];
			MinValue = ArrayToShow[0, 0];
			for (int i = 0; i < ArrayToShow.GetLength(0); i++)
			{
				for (int j = 0; j < ArrayToShow.GetLength(1); j++)
				{
					if (ArrayToShow[i, j] < MinValue)
						MinValue = ArrayToShow[i, j];
					if (ArrayToShow[i, j] > MaxValue)
						MaxValue = ArrayToShow[i, j];
				}
			}
			Redraw();
		}

		private void Redraw()
		{
			Bitmap img = new Bitmap(ArrayToShow.GetLength(0) * PictureScale, ArrayToShow.GetLength(1) * PictureScale);
			for (int i = 0; i < ArrayToShow.GetLength(0); i++)
			{
				for (int j = 0; j < ArrayToShow.GetLength(1); j++)
				{
					for (int k = 0; k < PictureScale; k++)
					{
						for (int l = 0; l < PictureScale; l++)
						{
							int color = (int)Math.Round(((ArrayToShow[i, j] - MinValue) / (MaxValue - MinValue)) * 255);
							img.SetPixel(i * PictureScale + k, j * PictureScale + l, Color.FromArgb(color, color, color));
						}
					}
				}
			}
			var visual = this.Controls["pictureBox1"] as PictureBox;
			visual.Image = img;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			PictureScale = (int)(sender as NumericUpDown).Value;
			Redraw();
		}
	}
}
