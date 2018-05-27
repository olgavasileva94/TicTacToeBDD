using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GameEngine
{
    public class Player
    {
        private String name;
        private String token;
        private int id;

        //constructors

        public Player()
        {
            this.SetName("");
            this.SetToken("");
            this.SetId(0);
        }

        public Player(String name, String token, int id)
        {
            this.SetName(name);
            this.SetToken(token);
            this.SetId(id);
        }

        //setters

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetToken(String token)
        {
            this.token = token;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        //getters

        public String GetName()
        {
            return this.name;
        }

        public String GetToken()
        {
            return this.token;
        }

        public int GetId()
        {
            return this.id;
        }
    };

    public class GameEngine
    {
        private ArrayList players;
        private String[,] gamePlace;
        private int step;

        //constructors

        public GameEngine()
        {
            this.SetStep(0);
            this.SetGamePlace(new string[0, 0]);
            this.SetPlayers(new ArrayList());
        }

        //setters

        private void SetGamePlace(String[,] gamePlace)
        {
            this.gamePlace = gamePlace;
        }

        private void SetPlayers(ArrayList players)
        {
            this.players = players;
        }

        private void SetStep(int step)
        {
            this.step = step;
        }

        //getters

        private String[,] GetGamePlace()
        {
            return this.gamePlace;
        }

        private ArrayList GetPlayers()
        {
            return this.players;
        }

        private int GetStep()
        {
            return this.step;
        }

        //methods

        public bool AddPlayer(String name = "", String token = "", int id = 0)
        {
            if (this.GetNumberOfPlayers() == 2)
            {
                return false;
            }

            this.GetPlayers().Add(new Player(name, token, id));

            return true;
        }

        public bool PlayerExist(int id)
        {
            foreach (Player player in this.GetPlayers())
            {
                if (player.GetId() == id)
                {
                    return true;
                }
            }

            return false;
        }

        public Player GetPlayer(int id)
        {
            foreach (Player player in this.GetPlayers())
            {
                if (player.GetId() == id)
                {
                    return player;
                }
            }

            throw new Exception("Player not foud");
        }

        public int GetNumberOfPlayers()
        {
            return this.GetPlayers().Count;
        }

        public void ClearPlayers()
        {
            ArrayList players = this.GetPlayers();
            players.Clear();
            this.SetPlayers(players);
        }

        public void CreateGamePlace(int size = 3)
        {
            this.gamePlace = new string[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.gamePlace[i, j] = "";
                }
            }
        }

        public void ClearGamePlace()
        {
            int size = this.GetSizeGamePlace();
            this.CreateGamePlace(size);
        }

        public int GetSizeGamePlace()
        {
            return (int) System.Math.Sqrt(this.gamePlace.Length);
        }

        public bool SetCellValue(int x, int y, String value)
        {
            if (this.GetCellValue(x, y) != "")
            {
                return false;
            }
            this.gamePlace[x, y] = value;

            return true;
        }

        public String GetCellValue(int x, int y)
        {
            return this.gamePlace[x, y];
        }

        public bool MakeAStep(int x, int y)
        {
            int step = this.GetStep();
            Player currentPlayer = new Player();
            int count = 0;
            foreach (Player player in this.GetPlayers())
            {
                if (count == step)
                {
                    currentPlayer = player;
                    break;
                }
                count++;
            }

            bool result = this.SetCellValue(x, y, currentPlayer.GetToken());
            
            if (step == this.GetNumberOfPlayers() - 1)
            {
                step = 0;
            } else
            {
                step++;
            }
            this.SetStep(step);

            return result;
        }

        public bool IsWin()
        {
            String[,] gamePlace = this.GetGamePlace();
            int size = this.GetSizeGamePlace();

            String token1 = "1";
            String token2 = "2";

            int count = 0;
            foreach (Player player in this.GetPlayers())
            {
                if (count == 0)
                {
                    token1 = player.GetToken();
                }
                if (count == 1)
                {
                    token2 = player.GetToken();
                    break;
                }

                count++;
            }

            for (int i = 0; i < size; i ++)
            {
                bool DiaWinT1 = true;
                bool HorWinT1 = true;
                bool VerWinT1 = true;
                bool DiaWinT2 = true;
                bool HorWinT2 = true;
                bool VerWinT2 = true;
                for (int j = 0; j < size; j++)
                {
                    if (gamePlace[i, j] != token1)
                    {
                        HorWinT1 = false;
                    }
                    if (gamePlace[j, i] != token1)
                    {
                        VerWinT1 = false;
                    }
                    if (gamePlace[j, j] != token1)
                    {
                        DiaWinT1 = false;
                    }
                    if (gamePlace[i, j] != token2)
                    {
                        HorWinT2 = false;
                    }
                    if (gamePlace[j, i] != token2)
                    {
                        VerWinT2 = false;
                    }
                    if (gamePlace[j, j] != token2)
                    {
                        DiaWinT2 = false;
                    }
                }
                if (HorWinT1 == true || VerWinT1 == true || DiaWinT1 == true)
                {
                    return true;
                }
                if (HorWinT2 == true || VerWinT2 == true || DiaWinT2 == true)
                {
                    return true;
                }
            }

            return false;
        }

        public Player GetCurrentPlayer()
        {
            int step = this.GetStep();

            Player currentPlayer = new Player();
            int count = 0;
            foreach (Player player in this.GetPlayers())
            {
                if (count == step)
                {
                    currentPlayer = player;
                    break;
                }
                count++;
            }

            return currentPlayer;
        }

        public Player GetWinPlayer()
        {
            int step = this.GetStep();
            if (step == 0)
            {
                step = 1;
            }
            else
            {
                step = 0;
            }

            Player winPlayer = new Player();
            int count = 0;
            foreach (Player player in this.GetPlayers())
            {
                if (count == step)
                {
                    winPlayer = player;
                    break;
                }
                count++;
            }

            return winPlayer;
        }

        public void NewGame(int size = 3, 
            String name1 = "Player1", String token1 = "X", int id1 = 1,
            String name2 = "Player2", String token2 = "Y", int id2 = 2)
        {
            this.CreateGamePlace(size);
            this.AddPlayer(name1, token1, id1);
            this.AddPlayer(name2, token2, id2);
            Random rand = new Random();
            if (rand.Next(0, 100) > 50)
            {
                this.SetStep(0);
            }
            else
            {
                this.SetStep(1);
            }
        }
    }
}
