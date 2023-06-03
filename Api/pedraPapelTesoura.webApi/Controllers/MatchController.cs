using Microsoft.AspNetCore.Mvc;
using pedraPapelTesoura.Application.Contracts;
using pedraPapelTesoura.Application.Contracts.Documents.Requests;
using pedraPapelTesoura.Application.Contracts.Documents.Responses;
using pedraPapelTesoura.Application.Contracts.Mappers;

namespace pedraPapelTesoura.webApi.Controllers

{
    [ApiController]
    [Route("match")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpPost]
        public MatchResponse AddMatch(MatchRequest request)
        {
         var match = _matchService.Add(request);

         return MatchMapper.ToResponse(match);
        }
    }
}
