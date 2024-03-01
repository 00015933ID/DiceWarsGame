using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace DiceWarsGame.DAL
{
    public partial class PlayerManager : DBManager
    {
        // Add new player
        public void Create(Player player)
        {
            using var connection = Connection;
            try
            {
                var sql = $"INSERT INTO pl_player " +
                          $"(pl_name_15933, pl_is_pvp_enabled_15933, pl_last_game_date_15933m, pl_score_15933) " +
                          $"VALUES ('{player._pl_name_15933}', " +
                          $"{Convert.ToInt32(player.pl_is_pvp_enabled_15933)}, " +
                          $"{new DateTime(2000, 1, 1).Ticks}, 0)";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
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
        }

        // Update existing player
        public void Update(Player player)
        {
            using var connection = Connection;
            try
            {
                var sql = $"UPDATE pl_player SET " +
                          $"pl_name_15933 = '{player.pl_name_15933}', " + 
                          $"pl_is_pvp_enabled_15933 = {Convert.ToInt32(player.pl_is_pvp_enabled_15933)} " + 
                          $"WHERE pl_id_15933 = {player.pl_id_15933}";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
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
        }
        
        // Get list of existing players
        public List<Player> GetAll()
        {
            using var connection = Connection;
            var result = new List<Player>();
            try
            {
                var sql = $"SELECT pl_id_15933, pl_name_15933, pl_is_pvp_enabled_15933, pl_last_game_date_15933, pl_score_15933 FROM pl_player";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var player = new Player();
                    player.pl_id_15933 = Convert.ToInt32(reader["pl_id_15933"]);
                    player.pl_name_15933 = Convert.ToString(reader["pl_name_15933"]);
                    player.pl_is_pvp_enabled_15933 = Convert.ToBoolean(reader["pl_is_pvp_enabled_15933"]);
                    player.pl_last_game_date_15933 = new DateTime(Convert.ToInt64(reader["pl_last_game_date_15933"]));
                    player.pl_score_15933 = Convert.ToInt32(reader["pl_score_15933"]);
                    result.Add(player);
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
