using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
	class Warrior
	{
		private const int ALLIANCE_STARTING_HEALTH = 100; // fields; camelCase
		private const int HORDE_STARTING_HEALTH = 100;

		private Faction faction; // enum field

		private int health; // more fields
		private string name;
		private bool isAlive;

		public bool IsAlive // properties; PascalCase
		{
			get // get; read-only
			{
				return isAlive;
			}
		}

		private Weapon weapon; // more fields; Weapon is a datatype
		private Armor armor;

		public Warrior(string name, Faction faction)
		{
			this.name = name;
			this.faction = faction;
			isAlive = true;

			switch (faction)
			{
				case Faction.Alliance:
					weapon = new Weapon(faction);
					armor = new Armor(faction);
					health = ALLIANCE_STARTING_HEALTH;
					break;
				case Faction.Horde:
					weapon = new Weapon(faction);
					armor = new Armor(faction);
					health = HORDE_STARTING_HEALTH;
					break;
				default:
					break;
			}
		}
	}
}