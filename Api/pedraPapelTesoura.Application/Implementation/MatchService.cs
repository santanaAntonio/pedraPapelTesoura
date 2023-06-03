using pedraPapelTesoura.Application.Contracts;
using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Application.Contracts.Mappers;
using pedraPapelTesoura.Domain.Contracts;
using pedraPapelTesoura.Domain.Models;
using pedraPapelTesoura.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                // Empate
                match.PlayerWon = false;
            }
            else if (
                (match.PlayerBet == Bet.PEDRA && match.IaBet == Bet.TESOURA) ||
                (match.PlayerBet == Bet.PAPEL && match.IaBet == Bet.PEDRA) ||
                (match.PlayerBet == Bet.TESOURA && match.IaBet == Bet.PAPEL)
            )
            {
                // Jogador venceu
                match.PlayerWon = true;
            }
            else
            {
                // IA venceu
                match.PlayerWon = false;
            }

            return match;
        }

        public Bet Sort()
        {
            var bets = Enum.GetValues(typeof(Bet));

            return (Bet)bets.GetValue(random.Next(bets.Length));
        }
    }
}
