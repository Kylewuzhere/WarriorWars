using WarriorWars.Enum;

namespace WarriorWars
{
	static class Tools
	{
		public static void ColorfulAttackWriteLine(string text, Faction faction)
		{
			if (faction == Faction.Alliance)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Magenta;

			}
			Console.WriteLine(text);
			Console.ResetColor();
		}

		public static void ColorfulWriteLine(string text, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ResetColor();
		}
	}
}
