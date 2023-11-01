using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
	class Armor
	{
		private const int ALLIANCE_ARMOR_POINTS = 5;
		private const int HORDE_ARMOR_POINTS = 5;

		private int armorPoints;

		public int ArmorPoints
		{
			get
			{
				return armorPoints;
			}
		}

		public Armor(Faction faction)
		{
			switch (faction)
			{
				case Faction.Alliance:
					armorPoints = ALLIANCE_ARMOR_POINTS;
					break;
				case Faction.Horde:
					armorPoints = HORDE_ARMOR_POINTS;
					break;
				default:
					break;
			}
		}
	}
}