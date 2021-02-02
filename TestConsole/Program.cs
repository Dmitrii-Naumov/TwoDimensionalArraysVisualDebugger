using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDimensionalArrayVisualizer;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			bool[,] array = new bool[3, 3];
			array[1, 1] = true;
			TwoDimensionalBoolArrayVisualizer.DebuggerSide.TestShowVisualizer(array);
			float[,] farray = new float[3, 3];
			farray[1, 1] = 10;
			farray[2, 2] = -5;
			TwoDimensionalFloatArrayVisualizer.DebuggerSide.TestShowVisualizer(farray);
		}
	}
}
