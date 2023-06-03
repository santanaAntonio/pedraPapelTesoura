using pedraPapelTesoura.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedraPapelTesoura.Domain.Contracts
{
    public interface IMatchRepository
    {
        public Match Add(Match partida);

    }
}
