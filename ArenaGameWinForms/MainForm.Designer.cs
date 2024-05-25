namespace ArenaGameWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			bNewGame = new Button();
			pictureBox1 = new PictureBox();
			ListBoxArcher = new ListBox();
			ListBoxMage = new ListBox();
			pictureBox2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// bNewGame
			// 
			bNewGame.Location = new Point(295, 12);
			bNewGame.Name = "bNewGame";
			bNewGame.Size = new Size(172, 29);
			bNewGame.TabIndex = 0;
			bNewGame.Text = "New Game";
			bNewGame.UseVisualStyleBackColor = true;
			bNewGame.Click += bNewGame_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.archer;
			pictureBox1.Location = new Point(110, 92);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(142, 128);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// ListBoxArcher
			// 
			ListBoxArcher.FormattingEnabled = true;
			ListBoxArcher.Location = new Point(29, 245);
			ListBoxArcher.Name = "ListBoxArcher";
			ListBoxArcher.Size = new Size(313, 324);
			ListBoxArcher.TabIndex = 3;
			// 
			// ListBoxMage
			// 
			ListBoxMage.FormattingEnabled = true;
			ListBoxMage.Location = new Point(459, 245);
			ListBoxMage.Name = "ListBoxMage";
			ListBoxMage.Size = new Size(313, 324);
			ListBoxMage.TabIndex = 4;
			ListBoxMage.SelectedIndexChanged += ListBoxRogue_SelectedIndexChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.mage;
			pictureBox2.Location = new Point(530, 92);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(142, 128);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 601);
			Controls.Add(ListBoxMage);
			Controls.Add(ListBoxArcher);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(bNewGame);
			Name = "MainForm";
			Text = "Arena Game";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button bNewGame;
        private PictureBox pictureBox1;
        private ListBox ListBoxArcher;
        private ListBox ListBoxMage;
		private PictureBox pictureBox2;
	}
}
