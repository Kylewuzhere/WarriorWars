using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
	class Weapon
	{
		private const int ALLIANCE_DAMAGE = 5;
		private const int HORDE_DAMAGE = 5;

		private int damage;

		public int Damage
		{
			get
			{
				return damage;
			}
		}

		public Weapon(Faction faction)
		{
			switch (faction)
			{
				case Faction.Alliance:
					damage = ALLIANCE_DAMAGE;
					break;
				case Faction.Horde:
					damage = HORDE_DAMAGE;
					break;
				default:
					break;
			}
		}
	}
}
