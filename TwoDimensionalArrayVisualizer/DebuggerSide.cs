﻿using System;
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
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			bool[,] arrayToShow = objectProvider.GetObject() as bool[,];
			if (arrayToShow == null || arrayToShow.GetLength(0) <= 0 || arrayToShow.GetLength(1) <= 0)
				return;

			DisplayForm form = new DisplayForm();
			form.ArrayToShow = ConvertToDoubleArray(arrayToShow);
			form.ShowDialog();
		}
		private static double[,] ConvertToDoubleArray(bool[,] arrayToConvert)
		{
			double[,] newArray = new double[arrayToConvert.GetLength(0), arrayToConvert.GetLength(1)];
			for (int i = 0; i < arrayToConvert.GetLength(0); i++)
			{
				for (int j = 0; j < arrayToConvert.GetLength(1); j++)
				{
					newArray[i, j] = arrayToConvert[i, j] ? 1 : 0;
				}
			}
			return newArray;
		}
		public static void TestShowVisualizer(object objectToVisualize)
		{
			VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));
			visualizerHost.ShowVisualizer();
		}
	}
}
