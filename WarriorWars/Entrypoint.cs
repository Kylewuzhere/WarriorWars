using WarriorWars.Enum;

namespace WarriorWars
{
	class Entrypoint
	{
		static Random rng = new();

		static void Main()
		{
			Warrior allianceWarrior = new("Alliance Warrior", Faction.Alliance);
			Warrior hordeWarrior = new("Horde Warrior", Faction.Horde);

			while (allianceWarrior.IsAlive && hordeWarrior.IsAlive)
			{
				if (rng.Next(0, 10) < 5)
				{
					allianceWarrior.Attack(hordeWarrior);
				}
				else
				{
					hordeWarrior.Attack(allianceWarrior);
				}
			}

		}
	}
}