
namespace Queens.Views
{
    partial class GameView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.Forfeit = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.MainRedirect = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Player1Wins = new System.Windows.Forms.Label();
            this.Player2Wins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnLabel.Location = new System.Drawing.Point(12, 27);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(0, 28);
            this.TurnLabel.TabIndex = 2;
            // 
            // Forfeit
            // 
            this.Forfeit.Location = new System.Drawing.Point(512, 12);
            this.Forfeit.Name = "Forfeit";
            this.Forfeit.Size = new System.Drawing.Size(94, 29);
            this.Forfeit.TabIndex = 3;
            this.Forfeit.Text = "Forfeit";
            this.Forfeit.UseVisualStyleBackColor = true;
            this.Forfeit.Click += new System.EventHandler(this.Forfeit_Click);
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(651, 26);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(94, 29);
            this.ReplayButton.TabIndex = 4;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // MainRedirect
            // 
            this.MainRedirect.Location = new System.Drawing.Point(512, 47);
            this.MainRedirect.Name = "MainRedirect";
            this.MainRedirect.Size = new System.Drawing.Size(94, 29);
            this.MainRedirect.TabIndex = 5;
            this.MainRedirect.Text = "MainMenu";
            this.MainRedirect.UseVisualStyleBackColor = false;
            this.MainRedirect.Click += new System.EventHandler(this.MainRedirect_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(398, 26);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(94, 29);
            this.NewGame.TabIndex = 6;
            this.NewGame.Text = "NewGame";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Player1Wins
            // 
            this.Player1Wins.AutoSize = true;
            this.Player1Wins.Location = new System.Drawing.Point(844, 21);
            this.Player1Wins.Name = "Player1Wins";
            this.Player1Wins.Size = new System.Drawing.Size(100, 20);
            this.Player1Wins.TabIndex = 7;
            this.Player1Wins.Text = "Player 1 Wins:";
            this.Player1Wins.Click += new System.EventHandler(this.Player1Wins_Click);
            // 
            // Player2Wins
            // 
            this.Player2Wins.AutoSize = true;
            this.Player2Wins.Location = new System.Drawing.Point(844, 56);
            this.Player2Wins.Name = "Player2Wins";
            this.Player2Wins.Size = new System.Drawing.Size(100, 20);
            this.Player2Wins.TabIndex = 8;
            this.Player2Wins.Text = "Player 2 Wins:";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.Player2Wins);
            this.Controls.Add(this.Player1Wins);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.MainRedirect);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.Forfeit);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.label1);
            this.Name = "GameView";
            this.Text = "GameView";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button Forfeit;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button MainRedirect;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label Player1Wins;
        private System.Windows.Forms.Label Player2Wins;
    }
}