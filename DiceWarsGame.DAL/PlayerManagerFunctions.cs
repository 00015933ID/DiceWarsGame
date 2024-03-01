
namespace DiceWarsGame.DAL
{
    partial class PlayerManager
    {
        

        public List<Player> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAll().OrderBy(p => p.pl_name_15933).ToList();
            }
            //if something is out of switch then show this

            return null;
        }
        //Filter by score
        public List<Player> Filter(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Loser:
                    return GetAll().Where(p => p.pl_score_15933 ==0).ToList();
                case ByAttribute.Winner:
                    return GetAll().Where(p => p.pl_score_15933 > 0).ToList();
            }
            //if something is out of switch then show this

            return null;
        }

    }
}
