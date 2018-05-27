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
        private int numberOfPlayers;

        //constructors

        public GameEngine()
        {
            this.players = new ArrayList();
            this._SetNumberOfPlayers(0);
        }

        //setters

        private void _SetNumberOfPlayers(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        //getters

        private int _GetNumberOfPlayers()
        {
            return this.numberOfPlayers;
        }

        //methods

        public bool AddPlayer(String name = "", String token = "", int id = 0)
        {
            if (this._GetNumberOfPlayers() == 2)
            {
                return false;
            }
            this._SetNumberOfPlayers(this._GetNumberOfPlayers() + 1);

            return true;
        }

        public Player GetPlayer(int id)
        {
            Player player = new Player();

            return player;
        }

        public int GetNumberOfPlayers()
        {
            return this._GetNumberOfPlayers();
        }

        public void ClearPlayers()
        {
            this._SetNumberOfPlayers(0);
        }
    }
}
