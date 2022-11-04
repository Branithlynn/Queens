using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Queens.Repository
{
    class GameRepository
    {
        public void ButtonClick(Button button, string player,bool PlayerColor)
        {
            button.Name = player;
            if (PlayerColor)
            {
                button.BackColor = Color.Blue;
            }
            else
            {
                button.BackColor = Color.Yellow;
            }
            button.Text = player;
        }
        public void TurnEnd(Button[,] buttons,Button LatestPlaced,bool PlayerColor)
        {
            string playerName = LatestPlaced.Name;
            LatestPlaced.Name = "Latest";
            string Coords = GetCoordinates(buttons,LatestPlaced, buttons.GetLength(0), buttons.GetLength(1));
            int XCoord = Convert.ToInt32(Coords.Split(",")[0]);
            int YCoord = Convert.ToInt32(Coords.Split(",")[1]);
            PlaceAndLock(buttons,XCoord,YCoord,PlayerColor);
            buttons[XCoord, YCoord].Text = playerName;
            buttons[XCoord, YCoord].BackColor = GetColor(PlayerColor);

            LatestPlaced.Name = playerName;
        }
        public string GetCoordinates(Button[,] buttons,Button LatestPlaced,int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < M; k++)
                {
                    if (buttons[i, k].Name == LatestPlaced.Name)
                    {
                        return i+","+k;
                    }
                }
            }
            return "";
        }
        public void PlaceAndLock(Button[,] buttons, int ButtonXCoord, int ButtonYCoord, bool PlayerColor)
        {
            //prosto praq edin if i ako udrq carica popup
            LockHorizontally(buttons, ButtonXCoord, ButtonYCoord, PlayerColor);
            LockVertically(buttons, ButtonXCoord, ButtonYCoord, PlayerColor);
            LockDiagonals(buttons, ButtonXCoord, ButtonYCoord, PlayerColor);
        }

        public void LockHorizontally(Button[,] buttons, int ButtonXCoord, int ButtonYCoord, bool PlayerColor)
        {
            for (int i = 0; i <= buttons.GetLength(0); i++)
            {
                try
                {
                    if (buttons[i, ButtonYCoord].Text != "*" )
                    {
                        buttons[i, ButtonYCoord].Text = "*";
                        buttons[i, ButtonYCoord].Name = "*";
                        buttons[i, ButtonYCoord].BackColor = GetColor(PlayerColor);
                        buttons[i, ButtonYCoord].Enabled = false;
                    }
                }
                catch
                {
                    continue;
                }
            }

        }
        public void LockVertically(Button[,] buttons, int x, int y, bool PlayerColor)
        {
            for (int i = 0; i <= buttons.GetLength(1); i++)
            {
                try
                {
                    if (buttons[x, i].Text != "*")
                    {
                        buttons[x, i].Text = "*";
                        buttons[x, i].Name = "*";
                        buttons[x, i].BackColor = GetColor(PlayerColor);
                        buttons[x, i].Enabled = false;
                    }
                }
                catch
                {
                    continue;
                }
            }

        }
       
        public void LockDiagonals(Button[,] buttons, int x, int y, bool PlayerColor)
        {
            int distance = 0;

            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                distance++;
                try
                {
                    if (buttons[x - distance, y - distance].Text != "*" &&
                        buttons[x - distance, y - distance].Text != GetOpositePlayer(PlayerColor))
                    {
                        buttons[x - distance, y - distance].Text = "*";
                        buttons[x - distance, y - distance].Name = "*";
                        buttons[x - distance, y - distance].BackColor = GetColor(PlayerColor);
                        buttons[x - distance, y - distance].Enabled = false;
                    }
                }
                catch
                {
                    break;
                }

            }

            distance = 0;
            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                distance++;
                try
                {
                    if (buttons[x + distance, y - distance].Text != "*" &&
                       buttons[x + distance, y - distance].Text != GetOpositePlayer(PlayerColor))
                    {
                        buttons[x + distance, y - distance].Text = "*";
                        buttons[x + distance, y - distance].Name = "*";
                        buttons[x + distance, y - distance].BackColor = GetColor(PlayerColor);
                        buttons[x + distance, y - distance].Enabled = false;
                    }
                }
                catch
                {
                    break;
                }

            }
            distance = 0;
            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                distance++;
                try
                {
                    if (buttons[x + distance, y + distance].Text != "*" &&
                        buttons[x + distance, y + distance].Text != GetOpositePlayer(PlayerColor))
                    {
                        buttons[x + distance, y + distance].Text = "*";
                        buttons[x + distance, y + distance].Name = "*";
                        buttons[x + distance, y + distance].BackColor = GetColor(PlayerColor);
                        buttons[x + distance, y + distance].Enabled = false;
                    }
                }
                catch
                {
                    break;
                }

            }

            distance = 0;
            for (int i = 0; i < buttons.GetLength(1); i++)
            {
                distance++;
                try
                {
                    if (buttons[x - distance, y + distance].Text != "*" &&
                        buttons[x - distance, y + distance].Text != GetOpositePlayer(PlayerColor))
                    {
                        buttons[x - distance, y + distance].Text = "*";
                        buttons[x - distance, y + distance].Name = "*";
                        buttons[x - distance, y + distance].BackColor = GetColor(PlayerColor);
                        buttons[x - distance, y + distance].Enabled = false;
                    }
                }
                catch
                {
                    break;
                }

            }
        }

        public string GetOpositePlayer(bool Playercolor)
        {
            if (Playercolor)
            {
                return "P2";
            }
            else
            {
                return "P1";
            }
        }
        public Color GetColor(bool player)
        {
            if (player)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Yellow;
            }
        }
        public bool CheckForWinner(Button[,] buttons)
        {
            foreach (var item in buttons)
            {
                if (item.Enabled)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
