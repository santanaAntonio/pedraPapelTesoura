using pedraPapelTesoura.Application.Contracts;
using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Application.Contracts.Mappers;
using pedraPapelTesoura.Domain.Contracts;
using pedraPapelTesoura.Domain.Models;
using pedraPapelTesoura.Domain.Models.Enums;

namespace pedraPapelTesoura.Application.Implementation
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;
        private static readonly Random random = new Random();

        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public Match Add(MatchRequest request)
        {
            Match match = MatchMapper.ToEntity(request, Sort());

            match = DecideWinner(match);

            return _matchRepository.Add(match);
        }

        public Match DecideWinner(Match match)
        {
            if (match.PlayerBet == match.IaBet)
            {
                match.Result = Result.Empate;
            }
            else if (
                (match.PlayerBet == Bet.PEDRA && match.IaBet == Bet.TESOURA) ||
                (match.PlayerBet == Bet.PAPEL && match.IaBet == Bet.PEDRA) ||
                (match.PlayerBet == Bet.TESOURA && match.IaBet == Bet.PAPEL)
            )
            {
                match.Result = Result.Vitoria;
            }
            else
            {
                match.Result = Result.Derrota;
            }

            return match;
        }

        public Bet Sort()
        {
            var bets = Enum.GetValues(typeof(Bet));

            return (Bet)bets.GetValue(random.Next(bets.Length));
        }

        public ScoreBoard ScoreBoard()
        {
            var list = _matchRepository.ListMatches();

            int wins = list.Count(match => match.Result == Result.Vitoria);
            int losses = list.Count(match => match.Result == Result.Derrota);
            int ties = list.Count(match => match.PlayerBet == match.IaBet);

            return new ScoreBoard { PlayerWin = wins, PlayerLoss = losses, Tie = ties };
        }

    }
}
