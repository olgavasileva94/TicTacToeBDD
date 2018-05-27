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

        //constructors

        public GameEngine()
        {
            this.players = new ArrayList();
        }

        //setters


        //getters


        //methods

        public bool AddPlayer(String name = "", String token = "", int id = 0)
        {
            if (this.GetNumberOfPlayers() == 2)
            {
                return false;
            }

            this.players.Add(new Player(name, token, id));

            return true;
        }

        public bool PlayerExist(int id)
        {
            foreach (Player player in this.players)
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
            foreach (Player player in this.players)
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
            return this.players.Count;
        }

        public void ClearPlayers()
        {
            this.players.Clear();
        }
    }
}
