using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Domain.Models;
using pedraPapelTesoura.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedraPapelTesoura.Application.Contracts
{
    public interface IMatchService
    {
        public Bet Sort();

        public Match DecideWinner(Match match);

        public Match Add(MatchRequest request);


      
        
    }
}
