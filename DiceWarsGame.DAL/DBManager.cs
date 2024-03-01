using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DiceWarsGame.DAL
{
    public class DBManager
    {
        protected SQLiteConnection Connection
        {
            get
            {
                return new SQLiteConnection(Properties.Settings.Default.ConnectionString);
            }
        }
    }
}
