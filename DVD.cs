using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
	internal class DVD : Movie
	{
		public DVD(string Title, Genre Genre, int RunTime, List<string> Scenes)
			: base(Title, Genre, RunTime, Scenes)
		{
			
		}
		public override void Play()
		{
			Console.WriteLine("Scene Selection");
			PrintScenes();
			Console.WriteLine("what scene would you like to watch?");
			int whichScene = int.Parse(Console.ReadLine())-1;
			Console.WriteLine(Scenes[whichScene]);
			Console.WriteLine("want to watch another? y/n");
			string selector = Console.ReadLine();
			bool userSelecting = true;
			while (userSelecting)
			{
				if (selector == "y")
				{
					Play();
					userSelecting = false;
				}
				else if (selector == "n")
				{

					userSelecting = false;
				}
			}
		}


	}
}
