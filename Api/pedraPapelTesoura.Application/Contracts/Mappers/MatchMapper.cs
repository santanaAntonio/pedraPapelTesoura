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
            return new Match { IaBet = iaBet, PlayerBet = request.PlayerBet };
        }

        public static MatchResponse ToResponse(Match match)
        {
            return new MatchResponse { IaBet = match.IaBet, PlayerBet = match.PlayerBet, PlayerWon = match.PlayerWon };
        }
    }
}
