using System;

namespace ArenaGameEngine
{
	public class Mage : Hero
	{
		private int mana;

		public Mage() : this("Gandalf")
		{

		}

		public Mage(string name) : base(name)
		{
			mana = 100;
		}

		public override int Attack()
		{
			int baseAttack = base.Attack();
			int critChance = Random.Shared.Next(1, 101);
			if (critChance <= 25)
			{
				int critMultiplier = Random.Shared.Next(150, 201);
				baseAttack = baseAttack * critMultiplier / 100;
				Console.WriteLine($"{Name} cast a critical spell!");
			}
			return baseAttack;
		}

		public override void TakeDamage(int incomingDamage)
		{
			if (mana > 0)
			{
				int shieldPercentage = Random.Shared.Next(30, 51);
				int damageAbsorbed = (incomingDamage * shieldPercentage) / 100;
				incomingDamage -= damageAbsorbed;
				mana -= damageAbsorbed;

				if (mana < 0)
				{
					mana = 0;
				}

				Console.WriteLine($"{Name}'s mana shield absorbed {damageAbsorbed} damage, remaining mana: {mana}");
			}
			base.TakeDamage(incomingDamage);
		}

		public void RegenerateMana(int amount)
		{
			mana += amount;
			if (mana > 100)
			{
				mana = 100;
			}
			Console.WriteLine($"{Name} regenerated {amount} mana, current mana: {mana}");
		}
	}
}
