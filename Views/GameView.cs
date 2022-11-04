using Queens.Entity;
using Queens.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using Queens.Tools;
using System.Windows.Forms;

namespace Queens.Views
{
    public partial class GameView : Form
    {
       
        public int NLength;
        public int MLength;
        public Button[,] buttons;
        int rounds = 1;
        public bool isVsBot;
        public bool isReplay;
        public List<ReplayMoves> Moves = new List<ReplayMoves>();
        public GameView()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            buttons = new Button[NLength, MLength];
            GenerateGrid();
            ReplayButton.Enabled = false;
            Player2Wins.Text = "Player 1 Wins:" + ControlsCommunication.PlayerOneWins;
            Player2Wins.Text = "Player 2 Wins:" + ControlsCommunication.PlayerTwoWins;

            if (isReplay)
            {
                Replay();
            }

        }
        public void GenerateGrid()
        {

            Panel panel = new Panel();
            this.Controls.Add(panel);
            panel.BackColor = Color.Orange;
            this.WindowState = FormWindowState.Maximized;
            panel.Location = new Point(0, 100);
            panel.Size = new Size(ClientSize.Width,ClientSize.Height-100);
            this.BackColor = Color.Orange;
            int formHeight = this.Height;
            int formWidth = this.Width;
            int y = 0;
            int x = 0;
            int defaultx = x;
            int pointA = panel.Height/ MLength;
            int pointB = panel.Width/NLength;
            
            for (int i = 0; i < NLength; i++)
            {
                for (int k = 0; k < MLength; k++)
                {
                    Button newButton = new Button();
                    newButton.Click += new EventHandler(this.OnClick);
                    this.Controls.Add(newButton);
                    newButton.Text = "";
                    newButton.BackColor = Color.White;
                    newButton.Location = new Point(x, y);
                    newButton.Size = new Size(pointB, pointA);
                    newButton.MouseEnter += OnMouseEnter;
                    newButton.MouseLeave += OnMouseLeave;
                    x = x + pointB;
                    buttons[i, k] = newButton;
                    panel.Controls.Add(newButton);
                }
                x = defaultx;
                y = y + pointA; 
            }
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (!isReplay)
            {
                Button dynamicButton = (sender as Button);
                if (dynamicButton.Enabled == true)
                {
                    dynamicButton.BackColor = Color.Blue;
                }
            }
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (!isReplay)
            {
                Button dynamicButton = (sender as Button);
                dynamicButton.BackColor = Color.White;
            }
            
        }
        private void OnClick(object sender, EventArgs e)
        {
            Random random = new Random();
            GameRepository gameRepository = new GameRepository();
            Button dynamicButton = (sender as Button);
            SafeMove(dynamicButton);
            bool PlayerColor;
            if (rounds % 2 == 1 || isVsBot)
            {
                PlayerColor = true;
                gameRepository.ButtonClick(dynamicButton, "P1", PlayerColor);
                UpdateView(dynamicButton, PlayerColor);
                if (isVsBot&&!gameRepository.CheckForWinner(buttons))
                {
                    
                    while (true)
                    {
                        int RandomX = random.Next(0, NLength);
                        int RandomY = random.Next(0, MLength);
                        if (buttons[RandomX, RandomY].Enabled)
                        {
                            gameRepository.ButtonClick(buttons[RandomX, RandomY], "P2", false);
                            UpdateView(buttons[RandomX, RandomY], false);
                            break;
                        }
                    }
                }
            }
            else if(!isVsBot)
            {
                PlayerColor = false;
                gameRepository.ButtonClick(dynamicButton, "P2", PlayerColor);
                UpdateView(dynamicButton, PlayerColor);
            }
            rounds++;
        }
        public void SafeMove(Button button)
        {
            GameRepository gameRepo = new GameRepository();
            ReplayRepository replayRepository = new ReplayRepository();
            ReplayMoves replaymove = new ReplayMoves();
            replaymove.Id = replayRepository.GetNextId(Moves);
            replaymove.Move = gameRepo.GetCoordinates(buttons, button, NLength, MLength);
            Moves.Add(replaymove);
        }
        public void UpdateView(Button dynamicButton,bool playercolor)
        {
            GameRepository gameRepository = new GameRepository();
            gameRepository.TurnEnd(buttons, dynamicButton, playercolor);
            if (gameRepository.CheckForWinner(buttons)&&playercolor)
            {
                TurnLabel.Text = "Player 1 Won";
                ReplayButton.Enabled = true;
                if (!isReplay)
                {
                    ControlsCommunication.PlayerOneWins++;
                    Player1Wins.Text = "Player 1 Wins:" + ControlsCommunication.PlayerOneWins;

                }

            }
            else if(gameRepository.CheckForWinner(buttons) && !playercolor)
            {
                TurnLabel.Text = "Player 2 Won";
                ReplayButton.Enabled = true;
                if (!isReplay)
                {
                    ControlsCommunication.PlayerTwoWins++;
                    Player2Wins.Text = "Player 2 Wins:" + ControlsCommunication.PlayerTwoWins;

                }
            }
            else
            {
                if (!isVsBot && rounds % 2 == 1)
                {
                    TurnLabel.Text = "Player 2 Moves";
                }
                else if (!isVsBot && rounds % 2 == 0)
                {
                    TurnLabel.Text = "Player 1 Moves";
                }
            }
           
        }

        private void Forfeit_Click(object sender, EventArgs e)
        {
            if (rounds % 2 == 1)
            {
                TurnLabel.Text = "Player 2 Wins";
                ControlsCommunication.PlayerTwoWins++;
                Player2Wins.Text = "Player 2 Wins:" + ControlsCommunication.PlayerTwoWins;

            }
            else
            {
                TurnLabel.Text = "Player 1 Wins";
                ControlsCommunication.PlayerOneWins++;
                Player1Wins.Text = "Player 1 Wins:" + ControlsCommunication.PlayerOneWins;

            }
            Forfeit.Enabled = false;
            DisableButtons();
        }

        public void DisableButtons()
        {
            for (int i = 0; i < NLength; i++)
            {
                for (int k = 0; k < MLength; k++)
                {
                    buttons[i, k].Enabled = false;
                }
            }
        }
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            GameView gameView = new GameView();
            this.Hide();
            gameView.Moves = Moves;
            gameView.isReplay = true;
            gameView.NLength = NLength;
            gameView.MLength = MLength;

            gameView.Show();
        }
        public ReplayMoves GetNextMove(int id)
        {
            foreach (var item in Moves)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void Replay()
        {
            Forfeit.Enabled = false;
            int id = 0;
            GameRepository gameRepository = new GameRepository();
            ReplayMoves replayMoves = GetNextMove(id);
            bool PlayerColor;

            foreach (var item in Moves)
            {
                int x = Convert.ToInt32(item.Move.Split(",")[0]);
                int y = Convert.ToInt32(item.Move.Split(",")[1]);
                if (rounds % 2 == 1)
                {
                    PlayerColor = true;
                    gameRepository.ButtonClick(buttons[x, y], "P1", PlayerColor);
                    UpdateView(buttons[x, y], PlayerColor);

                }
                else
                {
                    PlayerColor = false;
                    gameRepository.ButtonClick(buttons[x, y], "P2", PlayerColor);
                    UpdateView(buttons[x, y], PlayerColor);
                }
                rounds++;

                if (rounds % 2 == 0)
                {
                    TurnLabel.Text = "Player 2 moves";
                }
                else
                {
                    TurnLabel.Text = "Player 1 moves";

                }
                Thread.Sleep(1500);
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ChooseSizeView chooseSizeView = new ChooseSizeView();
            this.Hide();
            chooseSizeView.Show();
        }

        private void MainRedirect_Click(object sender, EventArgs e)
        {
            StartUp index = new StartUp();
            this.Hide();
            index.Show();
        }

        private void Player1Wins_Click(object sender, EventArgs e)
        {

        }
    }
}
