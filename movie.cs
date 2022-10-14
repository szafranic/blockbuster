using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
	abstract class Movie
	{
		public string Title { get; set; }
		public Genre Genre { get; set; }
		public int RunTime { get; set; }
		public List<string> Scenes { get; set; }
		public Movie(string Title, Genre Genre, int RunTime, List<string> Scenes)
		{
			this.Title = Title;
			this.Genre = Genre;
			this.RunTime = RunTime;
			this.Scenes = Scenes;
		}

		public virtual void PrintInfo()
		{
			Console.WriteLine($"Title: {Title}\t Genre: {Genre}\t Mins: {RunTime}");
		}
		public void PrintScenes()
		{
			for (int i = 0; i < Scenes.Count; i++)
			{
				Console.WriteLine((i+1)+" "+Scenes[i]);
			}
		}
		public abstract void Play();
	}
}
public enum Genre
{
	Drama,
	Comedy,
	Horror,
	Romance,
	Action
}