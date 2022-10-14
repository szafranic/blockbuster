namespace BlockbusterLab
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Blockbuster mine = new Blockbuster();
			List<string> a = new List<string>()
			{
				new string("scene 1"),
				new string("scene 2"),
				new string("scene 3")
			};
			mine.Movies = new List<Movie>()
			{
				new DVD("finding dory", Genre.Drama, 105, a),
				new DVD("incredibles 2", Genre.Action, 140, a),
				new DVD("you've got mail", Genre.Romance, 98, a),
				new VHS("finding nemo", Genre.Drama, 120, a),
				new VHS("incredibles", Genre.Action, 116, a),
				new VHS("frightening movie", Genre.Horror, 145, a)
			};



			Console.WriteLine("please select a movie number!");

			Movie selection = mine.CheckOut();

			Console.WriteLine("do you wanna watch this movie? y/n");
			string selector = Console.ReadLine();
			bool userSelecting = true;
			while (userSelecting)
			{
				if (selector == "y")
				{
					selection.Play();
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