using pedraPapelTesoura.Domain.Contracts;
using pedraPapelTesoura.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
