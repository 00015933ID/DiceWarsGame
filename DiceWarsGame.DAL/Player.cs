using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWarsGame.DAL
{
    public class Player
    {
        private string _pl_name_16603;
        private DateTime _pl_last_game_date_16603;
        private int _pl_score_16603;

        public int pl_id_16603 { get; set; }

        public string pl_name_16603
        {
            get => _pl_name_16603;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty");
                _pl_name_16603 = value;
            }
        }

        public bool _pl_is_pvp_enabled_16603 { get; set; }

        public DateTime pl_last_game_date_16603
        {

            get => _pl_last_game_date_16603;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Invalid Date");
                _pl_last_game_date_16603 = value;
            }
        }


        public int pl_score_16603
        {
            get => _pl_score_16603;
            set
            {
                if (_pl_score_16603 == null)
                    throw new Exception("Score cannot be empty");
                _pl_score_16603 = value;
            }
        }

    }
}
