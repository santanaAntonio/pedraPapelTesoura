using pedraPapelTesoura.Domain.Models.Enums;

namespace pedraPapelTesoura.Application.Contracts.Documents.Responses
{
    public class MatchResponse
    {
        public string PlayerWon { get; set; }

        public string PlayerBet { get; set; }

        public string IaBet { get; set; }

    }
}
