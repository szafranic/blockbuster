using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
	internal class Blockbuster
	{
		public List<Movie> Movies { get; set; }

		public Movie selection { get; set; }
		

		
		
		public void PrintMovies()
		{
			int index = 0;
			foreach (var movie in Movies)
			{
				Console.WriteLine((index+1)+". "+movie.Title);
				index++;
			}
		}
		public Movie CheckOut()
		{
			PrintMovies();
			Console.WriteLine("which movie would you like to check out?");
			int choice = int.Parse(Console.ReadLine());
			selection = Movies[choice];
			selection.PrintInfo();

			return selection;
		}

	}
}
