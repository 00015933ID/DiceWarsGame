using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWarsGame.DAL
{
    public class ClashManager : DBManager
    {
        public void Create(Clash clash)
        {
            using var connection = Connection;
            try
            {
                var sql = $@"
INSERT INTO [cl_clash]
           ([cl_player1_15933]
           ,[cl_player2_15933]
           ,[cl_date_15933]
           ,[cl_outcome_15933])
     VALUES
           ({clash.cl_player1_15933}
           ,{clash.cl_player2_15933}
           ,{clash.cl_date_15933.Ticks}
           ,{clash.cl_outcome_15933});
";
                //using var command = 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Get list of existing players
        public List<Clash> GetAll()
        {
            using var connection = Connection;
            var result = new List<Clash>();
            try
            {
                var sql = $"SELECT cl_id_15933, cl_player1_15933, cl_player2_15933, cl_date_15933, cl_outcome_15933 FROM cl_clash";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var clash = new Clash();
                    clash.cl_id_15933 = Convert.ToInt32(reader["cl_id_15933"]);
                    clash.cl_player1_15933 = Convert.ToInt32(reader["cl_player1_15933"]);
                    clash.cl_player2_15933 = Convert.ToInt32(reader["cl_player2_15933"]);
                    clash.cl_date_15933 = new DateTime(Convert.ToInt64(reader["cl_date_15933"]));
                    clash.cl_outcome_15933 = Convert.ToInt32(reader["cl_outcome_15933"]);
                    result.Add(clash);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
        }
    }
}
