using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.Drawing;
using TwoDimensionalArrayVisualizer;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(TwoDimensionalFloatArrayVisualizer.DebuggerSide),
typeof(VisualizerObjectSource),
Target = typeof(float[,]),
Description = "Two Dimensional Float Array Visualizer")]

namespace TwoDimensionalFloatArrayVisualizer
{
	public class DebuggerSide : DialogDebuggerVisualizer
	{
		const int SCALE = 5;
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			float[,] arrayToShow = objectProvider.GetObject() as float[,];
			if (arrayToShow.GetLength(0) <=0|| arrayToShow.GetLength(1) <= 0)
				return;
			float maxValue = arrayToShow[0, 0];
			float minValue = arrayToShow[0, 0];
			for (int i = 0; i < arrayToShow.GetLength(0); i++)
			{
				for (int j = 0; j < arrayToShow.GetLength(1); j++)
				{
					if (arrayToShow[i, j] < minValue)
						minValue = arrayToShow[i, j];
					if (arrayToShow[i, j] > maxValue)
						maxValue = arrayToShow[i, j];
				}
			}
			Bitmap img = new Bitmap(arrayToShow.GetLength(0) * SCALE, arrayToShow.GetLength(1) * SCALE);
			for (int i = 0; i < arrayToShow.GetLength(0); i++)
			{
				for (int j = 0; j < arrayToShow.GetLength(1); j++)
				{
					for (int k = 0; k < SCALE; k++)
					{
						for (int l = 0; l < SCALE; l++)
						{
							int color = (int)Math.Round(((arrayToShow[i, j] - minValue) / (maxValue - minValue)) * 255);
							img.SetPixel(i * SCALE + k, j * SCALE + l, Color.FromArgb(color, color, color));
						}
					}
				}
			}
			DisplayForm form = new DisplayForm();
			var visual = form.Controls["pictureBox1"] as PictureBox;
			visual.Image = img;
			form.ShowDialog();
			//MessageBox.Show(message.ToString());
		}
		public static void TestShowVisualizer(object objectToVisualize)
		{
			VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
			visualizerHost.ShowVisualizer();
		}
	}
}
