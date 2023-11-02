using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
	class Warrior
	{
		private const int ALLIANCE_STARTING_HEALTH = 20; // fields; camelCase
		private const int HORDE_STARTING_HEALTH = 20;

		private readonly Faction FACTION; // enum field

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
			FACTION = faction;
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

		public void Attack(Warrior enemyWarrior)
		{
			int damage = weapon.Damage / enemyWarrior.armor.ArmorPoints;

			enemyWarrior.health -= damage;

			AttackResult(enemyWarrior, damage);
		}

		private void AttackResult(Warrior enemyWarrior, int damage)
		{
			if (enemyWarrior.health <= 0)
			{
				enemyWarrior.isAlive = false;

				Tools.ColorfulAttackWriteLine($"{name} hits {enemyWarrior.name} for {damage} damage! {enemyWarrior.name}'s remaining health: {enemyWarrior.health} ", FACTION);

				Tools.ColorfulWriteLine($"{enemyWarrior.name} has died!", ConsoleColor.Red);
				Tools.ColorfulWriteLine($"{name} has won!", ConsoleColor.Green);
			}
			else
			{

				Tools.ColorfulAttackWriteLine($"{name} hits {enemyWarrior.name} for {damage} damage! {enemyWarrior.name}'s remaining health: {enemyWarrior.health} ", FACTION);
			}

			Thread.Sleep(50);
		}
	}
}