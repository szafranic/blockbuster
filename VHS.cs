using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
	internal class VHS : Movie
	{
		public int CurrentScene {get; set;}

		public VHS(string Title, Genre Genre, int RunTime, List<string> Scenes)
			: base(Title, Genre, RunTime, Scenes)
		{
			this.CurrentScene = CurrentScene;
		}
		public override void Play()
		{
			Console.WriteLine(Scenes[CurrentScene]);
			CurrentScene++;
			Console.WriteLine("want to keep watching? y/n or *rewind*");
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
				else if (selector == "rewind")
				{

					Rewind();
					Console.WriteLine("...rewinding");
					Play();
				}
			}
		}


		public void Rewind()
		{
			CurrentScene = 0;
		}
	}
}
