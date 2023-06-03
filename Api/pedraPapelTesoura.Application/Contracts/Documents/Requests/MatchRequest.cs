using pedraPapelTesoura.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedraPapelTesoura.Application.Contracts.Documents.Requests
{
    public class MatchRequest
    {
        public Bet PlayerBet { get; set; }

    }
}
