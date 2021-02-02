using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			bool[,] map = new bool[5, 5];
			map[0, 0] = true;
			map[0, 1] = true;
			map[0, 2] = true;
			map[0, 3] = true;


			map[1, 2] = true;

			map[2, 0] = true;
			map[2, 1] = true;
			map[2, 2] = true;
			map[2, 3] = true;

			map[3, 0] = true;
			map[3, 1] = true;
			map[3, 2] = true;
			map[3, 3] = true;
			TwoDimensionalBoolArrayVisualizer.DebuggerSide.TestShowVisualizer(map);
			float[,] farray = new float[3, 3];
			farray[1, 1] = 10;
			farray[2, 2] = -5;
			TwoDimensionalFloatArrayVisualizer.DebuggerSide.TestShowVisualizer(farray);
		}
	}
}
