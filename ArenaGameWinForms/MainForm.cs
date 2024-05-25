using ArenaGameEngine;
using System.Windows.Forms;

namespace ArenaGameWinForms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public void AddItemToListBoxKnight(string s)
		{
			ListBoxArcher.Items.Add(s);
		}

		public void AddItemToListBoxRogue(string s)
		{
			ListBoxMage.Items.Add(s);
		}

		internal void AddItemToListBoxArcher(string message)
		{
			ListBoxArcher.Items.Add(message);
		}

		internal void AddItemToListBoxMage(string message)
		{
			ListBoxMage.Items.Add(message);
		}

		private void bNewGame_Click(object sender, EventArgs e)
		{
			Knight knight = new Knight("Sir John");
			Rogue rogue = new Rogue("Slim Shady");
			Archer archer = new Archer("Ashe");
			Mage mage = new Mage("Gandalf the black");

			Arena arena = new Arena(archer, mage);
			arena.EventListener = new WinFormsGameEventListener(this);
			Hero winner = arena.Battle();

			MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
		}

		private void ListBoxRogue_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
