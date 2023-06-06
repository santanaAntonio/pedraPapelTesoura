using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Domain.Models;
using pedraPapelTesoura.Domain.Models.Enums;

namespace pedraPapelTesoura.Application.Contracts
{
    public interface IMatchService
    {
        public Bet Sort();

        public Match DecideWinner(Match match);

        public Match Add(MatchRequest request);

        public ScoreBoard ScoreBoard();

    }
}
