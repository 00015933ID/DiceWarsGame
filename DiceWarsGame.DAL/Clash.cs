using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWarsGame.DAL
{
    public class Clash 
    {
        private DateTime _cl_date_15933;
        private int _cl_outcome_15933;

        public int cl_id_15933 { get; set; }
        public int cl_player1_15933 { get; set; }
        public int cl_player2_15933 { get; set; }

        //validation of clash
        public DateTime cl_date_15933
        {

            get => _cl_date_15933;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Invalid Date");
                _cl_date_15933 = value;
            }
        }

        public int cl_outcome_15933
        {
            get => _cl_outcome_15933;
            set
            {
                if (_cl_outcome_15933 == null)
                {
                    throw new Exception("Invalid outcome");
                }
            }
        }

        public Clash()
        {

        }

        public Clash(int cl_player1_15933, int cl_player2_15933, DateTime cl_date_15933, int cl_outcome_15933)
        {
            cl_player1_15933 = cl_player1_15933;
            cl_player2_15933 = cl_player2_15933;
            _cl_date_15933 = cl_date_15933;
            _cl_outcome_15933 = cl_outcome_15933;
        }

    }

    // TODO
    public enum Outcome
    {
        tie = 0,
        pl_1_win = 1,
        pl_2_win = 2,
    }
}
