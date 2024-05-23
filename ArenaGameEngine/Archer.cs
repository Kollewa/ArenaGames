using System;

namespace ArenaGameEngine
{
	public class Archer : Hero
	{
		public Archer() : this("Robin Hood")
		{

		}

		public Archer(string name) : base(name)
		{
			attackCount = 0;
		}

		private int attackCount;

		public override int Attack()
		{
			attackCount = attackCount + 1;
			int baseAttack = base.Attack();
			if (attackCount == 3)
			{
				int chance = Random.Shared.Next(1, 101);
				if (chance <= 50)
				{
					baseAttack = baseAttack * 2;
				}
				attackCount = 0;
			}
			return baseAttack;
		}

		public override void TakeDamage(int incomingDamage)
		{
			int evadeChance = Random.Shared.Next(1, 101);
			if (evadeChance > 10 && evadeChance <= 30)
			{
				Console.WriteLine($"{Name} evaded the attack!");
				incomingDamage = 0;
			}
			base.TakeDamage(incomingDamage);
		}
	}
}
