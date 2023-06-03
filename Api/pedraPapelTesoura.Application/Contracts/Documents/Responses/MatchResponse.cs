using pedraPapelTesoura.Domain.Models.Enums;

namespace pedraPapelTesoura.Application.Contracts.Documents.Responses
{
    public class MatchResponse
    {
        public bool PlayerWon { get; set; }

        public Bet PlayerBet { get; set; }

        public Bet IaBet { get; set; }
    }
}
