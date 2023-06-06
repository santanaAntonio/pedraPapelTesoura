using pedraPapelTesoura.Domain.Models;

namespace pedraPapelTesoura.Domain.Contracts
{
    public interface IMatchRepository
    {
        public Match Add(Match partida);

        public List<Match> ListMatches();



    }
}
