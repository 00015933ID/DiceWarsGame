using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWarsGame.DAL
{
    public class Clash
    {
        private DateTime _cl_date;
        private Outcome _cl_outcome;

        public int cl_id_15933 { get; set; }
        public Player? cl_player1_15933 { get; set; }
        public Player? cl_player2_15933 { get; set; }

        public DateTime cl_date_15933
        {

            get => _cl_date;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Invalid Date");
                _cl_date = value;
            }
        }

        public Outcome cl_outcome
        {
            get => _cl_outcome;
            set
            {
                if (_cl_outcome == null)
                {
                    throw new Exception("Invalid outcome");
                }
            }
        }

    }

    public enum Outcome
    {
        tie = 0,
        pl_1_win = 1,
        pl_2_win = 2,
    }
}
