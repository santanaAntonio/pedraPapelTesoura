using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Application.Contracts.Documents.Responses;
using pedraPapelTesoura.Domain.Models;
using pedraPapelTesoura.Domain.Models.Enums;

namespace pedraPapelTesoura.Application.Contracts.Mappers
{
    public class MatchMapper
    {
        public static Match ToEntity(MatchRequest request, Bet iaBet)
        {
            Bet betEnum = (Bet)Enum.Parse(typeof(Bet), request.PlayerBet, true);
            return new Match { IaBet = iaBet, PlayerBet = betEnum};
        }

        public static MatchResponse ToResponse(Match match)
        {
            return new MatchResponse { IaBet = match.IaBet.ToString(), PlayerBet = match.PlayerBet.ToString(), PlayerWon = match.Result.ToString()};
        }
    }
}
