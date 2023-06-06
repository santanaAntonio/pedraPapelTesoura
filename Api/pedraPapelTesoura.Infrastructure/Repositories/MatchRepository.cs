using pedraPapelTesoura.Domain.Contracts;
using pedraPapelTesoura.Domain.Models;

namespace pedraPapelTesoura.Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private static readonly List <Match> _partidas = new List <Match> ();

        public Match Add(Match partida) 
        {
        _partidas.Add (partida);

            return partida;
        }

        public List<Match> ListMatches() 
        {
            return _partidas;
        }
    }
}
