using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWarsGame.DAL
{
    public class Player
    {
        public string _pl_name_15933;
        private DateTime _pl_last_game_date_15933;
        private int _pl_score_15933;

        public int pl_id_15933 { get; set; }

        //Validation of player
        public string pl_name_15933
        {
            get => _pl_name_15933;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                _pl_name_15933 = value;
            }
        }

        public bool pl_is_pvp_enabled_15933 { get; set; }

        public DateTime pl_last_game_date_15933
        {

            get => _pl_last_game_date_15933;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Invalid Date");
                _pl_last_game_date_15933 = value;
            }
        }

        public int pl_score_15933
        {
            get => _pl_score_15933;
            set
            {
                if (_pl_score_15933 == null)
                    throw new Exception("Score cannot be empty");
                _pl_score_15933 = value;
            }
        }

        public Player()
        {

        }

        public Player(string pl_name_15933, bool pl_is_pvp_enabled_15933, DateTime pl_last_game_date_15933, int pl_score_15933)
        {
            _pl_name_15933 = pl_name_15933;
            pl_is_pvp_enabled_15933 = pl_is_pvp_enabled_15933;
            _pl_last_game_date_15933 = pl_last_game_date_15933;
            _pl_score_15933 = pl_score_15933;
        }
    }
}
