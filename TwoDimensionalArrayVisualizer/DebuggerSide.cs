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
typeof(TwoDimensionalBoolArrayVisualizer.DebuggerSide),
typeof(VisualizerObjectSource),
Target = typeof(bool[,]),
Description = "Two Dimensional Bool Array Visualizer")]

namespace TwoDimensionalBoolArrayVisualizer
{
	public class DebuggerSide : DialogDebuggerVisualizer
	{
		const int SCALE = 5;
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			bool[,] arrayToShow = objectProvider.GetObject() as bool[,];
			Bitmap img = new Bitmap(arrayToShow.GetLength(0) * SCALE, arrayToShow.GetLength(1) * SCALE);
			for (int i = 0; i < arrayToShow.GetLength(0); i++)
			{
				for (int j = 0; j < arrayToShow.GetLength(1); j++)
				{
					for (int k = 0; k < SCALE; k++)
					{
						for (int l = 0; l < SCALE; l++)
						{
							img.SetPixel(i * SCALE + k, j * SCALE + l, arrayToShow[i, j] ? Color.Black : Color.White);
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
