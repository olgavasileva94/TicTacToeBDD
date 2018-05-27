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

        //constructors

        public GameEngine()
        {
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

        //getters

        private String[,] GetGamePlace()
        {
            return this.gamePlace;
        }

        private ArrayList GetPlayers()
        {
            return this.players;
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
            this.gamePlace = new string[0, 0];
        }

        public void ClearGamePlace()
        {
            int size = this.GetSizeGamePlace();
            this.gamePlace = new string[size, size];
        }

        public int GetSizeGamePlace()
        {
            return 0;
        }

        public bool SetCellValue(int x, int y)
        {
            return true;
        }

        public String GetCellValue(int x, int y)
        {
            return "0";
        }
    }
}
