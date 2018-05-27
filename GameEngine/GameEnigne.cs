using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class GameEngine
    {
        private int numberOfPlayers;

        //constructors

        public GameEngine()
        {
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

        public bool AddPlayer(String name = "", String token = "")
        {
            if (this._GetNumberOfPlayers() == 2)
            {
                return false;
            }
            this._SetNumberOfPlayers(this._GetNumberOfPlayers() + 1);

            return true;
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
